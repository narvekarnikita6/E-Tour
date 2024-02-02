using ETourProject1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis;

namespace ETourProject1.Repository
{
    public interface IPackage_Master_Interface
    {
        Task<ActionResult<Package_Master>> AddPackage(Package_Master packageMaster);
        Task<ActionResult<IEnumerable<Package_Master>>> GetPackageMasters();

        Task<ActionResult<Package_Master>?> GetById(int id);
        //Task<ActionResult<IEnumerable<Package_master>>> getByCatmaster(int id);
    }
}
