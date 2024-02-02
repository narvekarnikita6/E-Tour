using ETourProject1.Models;
using Microsoft.AspNetCore.Mvc;

namespace ETourProject1.Repository
{
    public interface IPassangerMasterInterface
    {
        public Task<ActionResult<Passanger_Master>> AddPassenger(Passanger_Master passanger_Master);

        public Task<Passanger_Master> GetById(int id);
        public Task<ActionResult<IEnumerable<Passanger_Master>?>> GetPassanger();



        //int GetByCustId(int id);
        // List<Passanger_Master> FindByCustId(int id);


        // int FindSum(int id);
    }
}






