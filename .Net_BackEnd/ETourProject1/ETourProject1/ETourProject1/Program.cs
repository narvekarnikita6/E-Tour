using ETourProject1.Repository;
using Microsoft.EntityFrameworkCore;
/*using WebApplicationOneToMany.Models;*/

namespace ETourProject1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllers();

         /*   builder.Services.AddTransient<IBookingHeaderRepository, BookingHeaderRepository>();
            builder.Services.AddTransient<ICategory_MasterInterface, Category_MasterRepository>();
            builder.Services.AddTransient<ICost_MasterInterface, Cost_MasterRepository>();
            builder.Services.AddTransient<ICustomer_MasterInterface, Customer_MasterRepository>();
            builder.Services.AddTransient<IDate_Masterinterface, SQLDateMasterRepository>();
            builder.Services.AddTransient<IPackage_Master_Interface, Package_Master_Impl>();
            builder.Services.AddTransient<Itinerary_MasterInterface, ItineraryRepository>();
          */

            builder.Services.AddDbContext<Appdbcontext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("ETourDbString")));

            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddCors(options =>
            {
                options.AddPolicy("MyAllowSpecificOrigins",
                                  builder =>
                                  {
                                      builder.WithOrigins("*").AllowAnyHeader().AllowAnyMethod();
                                  });
            });
           
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
