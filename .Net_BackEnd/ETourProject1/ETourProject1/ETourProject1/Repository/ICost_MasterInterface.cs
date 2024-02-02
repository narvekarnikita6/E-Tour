using ETourProject1.Models;
using Microsoft.AspNetCore.Mvc;

namespace ETourProject1.Repository
{
    public interface ICost_MasterInterface
    {
        Task<ActionResult<Cost_Master>?> GetCost(int Id);
        Task<ActionResult<IEnumerable<Cost_Master>>> GetAllCost();
        Task<ActionResult<Cost_Master>> Add(Cost_Master cost);



    }
}
