using ETourProject1.Models;
using ETourProject1.Repository;
using Microsoft.AspNetCore.Mvc;

namespace ETourProject1.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class Passanger_MasterController : ControllerBase
    {
        private readonly IPassangerMasterInterface _repository;

        public Passanger_MasterController(IPassangerMasterInterface repository)
        {
            _repository = repository;
        }


        [HttpGet]
        public async Task<ActionResult<IEnumerable<Passanger_Master>>> GetPassanger()
        {
            if (await _repository.GetPassanger() == null)
            {
                return NotFound();
            }
            return await _repository.GetPassanger();
        }



        // GET: api/Passanger_Master/5
        [HttpGet("{id:int}")]
        public async Task<ActionResult<Passanger_Master>> GetByPassangerId(int id)
        {
            var passanger = await _repository.GetById(id);
            return passanger == null ? NotFound() : passanger;
        }


        [HttpPost]
        public async Task<ActionResult<Passanger_Master>> PostPassanger_Master(Passanger_Master passanger)
        {
            await _repository.AddPassenger(passanger);

            return CreatedAtAction("GetPassanger_Master", new { id = passanger.PassangerId }, passanger);
        }




    }
}
