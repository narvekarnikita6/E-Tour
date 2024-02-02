using ETourProject1.Models;
using ETourProject1.Repository;
using Microsoft.AspNetCore.Mvc;

namespace ETourProject1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Package_MasterController : ControllerBase
    {
        private readonly IPackage_Master_Interface _repository;

        public Package_MasterController(IPackage_Master_Interface repository)
        {
            _repository = repository;
        }



        [HttpPost]
        public async Task<ActionResult<Package_Master>> PostPackage_master(Package_Master package)
        {
            await _repository.AddPackage(package);

            return CreatedAtAction("GetPassanger_Master", new { id = package.PkgId }, package);
        }



        [HttpGet]

        public async Task<ActionResult<IEnumerable<Package_Master>>> GetPackage()
        {
            if (await _repository.GetPackageMasters() == null)
            {
                return NotFound();
            }
            return await _repository.GetPackageMasters();
        }



        [HttpGet("{id:int}")]
        public async Task<ActionResult<Package_Master>> GetByPackageId(int id)
        {
            var package = await _repository.GetById(id);
            return package == null ? NotFound() : package;
        }


    }
}