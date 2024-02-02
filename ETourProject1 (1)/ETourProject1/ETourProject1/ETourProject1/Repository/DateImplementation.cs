using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ETourProject1.Models; // Make sure to adjust the namespace as needed
using ETourProject1.Repository;

namespace WebApplicationOneToMany.Models
{
    public class DateImplementation : IDate_Masterinterface
    {
        private readonly Appdbcontext context;

        public DateImplementation(Appdbcontext context)
        {
            this.context = context;
        }

        public async Task<ActionResult<Date_Master>?> GetDate(DateTime date)
        {
            var dateMaster = await context.DateMaster.FirstOrDefaultAsync(d => d.DepartDate == date);
            return dateMaster;
        }

        public async Task<ActionResult<IEnumerable<Date_Master>>> GetAllDate_Master()
        {
            return await context.DateMaster.ToListAsync();
        }

        public async Task<ActionResult<Date_Master>> Add(Date_Master date)
        {
            context.DateMaster.Add(date);
            await context.SaveChangesAsync();
            return date;
        }


        private bool DateMasterExists(int id)
        {
            return context.DateMaster.Any(e => e.DepartureId == id);
        }
    }
}
