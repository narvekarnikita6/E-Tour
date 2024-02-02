using ETourProject1.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ETourProject1.Models;

namespace ETourProject1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Category_MasterController : ControllerBase
    {
        private readonly ICategory_MasterInterface _repository;

        public Category_MasterController(ICategory_MasterInterface repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Category_Master>>> GetCategories()
        {
            var categories = await _repository.GetAllCategory();
            if (categories == null)
            {
                return NotFound();
            }

            return categories.Value.ToList(); // Assuming GetAllCategory() returns an ActionResult<IEnumerable<Category_Master>>
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<Category_Master>> GetById(int id)
        {
            var category = await _repository.GetCategory(id);
            if (category.Value == null)
            {
                return NotFound();
            }

            return category.Value;
        }


        [HttpPost]
        public async Task<ActionResult<Category_Master>> PostCategory(Category_Master category)
        {
            var addedCategory = await _repository.Add(category);
            return CreatedAtAction(nameof(GetById), new { id = addedCategory.Value.CatMasterId }, addedCategory.Value);
        }

    }
}
