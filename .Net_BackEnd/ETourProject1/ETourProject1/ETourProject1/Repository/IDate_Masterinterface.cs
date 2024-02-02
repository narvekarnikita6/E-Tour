using ETourProject1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;

namespace WebApplicationOneToMany.Models
{
    public interface IDate_Masterinterface
    {
        Task<ActionResult<Date_Master>?> GetDate(DateTime Date);
        Task<ActionResult<IEnumerable<Date_Master>>> GetAllDate_Master();
        Task<ActionResult<Date_Master>> Add(Date_Master Date);

        // ActionResult<IEnumerable<dynamic>> GetName(string name);

    }
}
