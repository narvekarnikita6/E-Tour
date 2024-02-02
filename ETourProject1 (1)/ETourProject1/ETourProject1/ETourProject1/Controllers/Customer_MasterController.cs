using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ETourProject1.Models;
using ETourProject1.Repository;

namespace ETourProject1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Customer_MasterController : ControllerBase
    {
        private readonly Appdbcontext _context;

        public Customer_MasterController(Appdbcontext context)
        {
            _context = context;
        }

        // GET: api/Customer_Master
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Customer_Master>>> GetCustomer_Master()
        {
            if (_context.CustomerMaster == null)
            {
                return NotFound();
            }
            return await _context.CustomerMaster.ToListAsync();
        }

        // GET: api/Customer_Master/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Customer_Master>> GetCustomer_Master(int id)
        {
            if (_context.CustomerMaster == null)
            {
                return NotFound();
            }
            var customer_Master = await _context.CustomerMaster.FindAsync(id);

            if (customer_Master == null)
            {
                return NotFound();
            }

            return customer_Master;
        }


        // POST: api/Customer_Master
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Customer_Master>> PostCustomer_Master(Customer_Master customer_Master)
        {
            if (_context.CustomerMaster == null)
            {
                return Problem("Entity set 'Appdbcontext.Customer_Master'  is null.");
            }
            _context.CustomerMaster.Add(customer_Master);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCustomer_Master", new { id = customer_Master.CustId }, customer_Master);
        }


        private bool Customer_MasterExists(int id)
        {
            return (_context.CustomerMaster?.Any(e => e.CustId == id)).GetValueOrDefault();
        }
    }
}
