using ETourProject1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ETourProject1.Repository
{
    public class Cost_MasterRepository : ICost_MasterInterface
    {
        private readonly Appdbcontext context;

        public Cost_MasterRepository(Appdbcontext context)
        {
            this.context = context;
        }


        public async Task<ActionResult<Cost_Master>> Add(Cost_Master cost)
        {
            context.CostMaster.Add(cost);
            await context.SaveChangesAsync();
            return cost;
        }


        public async Task<ActionResult<IEnumerable<Cost_Master>>> GetAllCost()
        {
            if (context.CostMaster == null)
            {
                return null;
            }
            return await context.CostMaster.ToListAsync();
        }

        public async Task<ActionResult<Cost_Master>> GetCost(int Id)
        {
            if (context.CostMaster == null)
                return null;
            Cost_Master cost = await context.CostMaster.FindAsync(Id);

            if (cost == null)
            {
                return null;
            }
            //*var cost = await context.Cost.FindAsync(id);
            return cost;
        }



        private bool CostExists(int id)
        {
            return (context.CostMaster?.Any(e => e.CostId == id)).GetValueOrDefault();
        }
    }
}
