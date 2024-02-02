using ETourProject1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ETourProject1.Repository
{
        public class Category_MasterRepository : ICategory_MasterInterface
        {
            private readonly Appdbcontext context;

            public Category_MasterRepository(Appdbcontext context)
            {
                this.context = context;
            }

            public async Task<ActionResult<Category_Master>> Add(Category_Master category)
            {
                context.CategoryMaster.Add(category);
                await context.SaveChangesAsync();
                return category;
            }

            public ActionResult<IEnumerable<dynamic>> Get(int id)
            {
                throw new NotImplementedException();
            }

            public async Task<ActionResult<IEnumerable<Category_Master>>> GetAllCategory()
            {
                if (context.CategoryMaster == null)
                {
                    return null;
                }
                return await context.CategoryMaster.ToListAsync();
            }

            public async Task<ActionResult<Category_Master>> GetCategory(int id)
            {
                var category = await context.CategoryMaster.FindAsync(id);
                return category;
            }


            private bool CategoryExists(int id)
            {
                return (context.CategoryMaster?.Any(e => e.CatMasterId == id)).GetValueOrDefault();
            }
        }
    }


