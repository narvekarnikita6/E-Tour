using ETourProject1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ETourProject1.Repository
{
    public class Passanger_MasterRepository : IPassangerMasterInterface
    {


        private readonly Appdbcontext context;

        public Passanger_MasterRepository(Appdbcontext context)
        {
            this.context = context;
        }


        public async Task<ActionResult<Passanger_Master>> AddPassenger(Passanger_Master passanger_Master)
        {
            context.Passanger.Add(passanger_Master);
            await context.SaveChangesAsync();
            return passanger_Master;
        }

        async Task<Passanger_Master> IPassangerMasterInterface.GetById(int id)
        {

            if (context.Passanger == null)
            {
                return null;
            }
            Passanger_Master passanger_Master = await context.Passanger.FindAsync(id);
            if (passanger_Master == null)
            {
                return null;
            }
            return passanger_Master;
        }

        async Task<ActionResult<IEnumerable<Passanger_Master>?>> IPassangerMasterInterface.GetPassanger()
        {
            if (context.Passanger == null)
            {
                return null;
            }

            return await context.Passanger.ToListAsync();
        }
    }
}

