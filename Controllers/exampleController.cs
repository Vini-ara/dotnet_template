using Microsoft.AspNetCore.Mvc;

namespace Recipes.Controllers
{
    [Route("api/example")]
    [ApiController]
    public class ExampleController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAll()
        {
            string[] example = ["example1", "example2", "example3"];

            return Ok(example);
        }

        [HttpGet("{id:guid}")]
        public IActionResult GetById(Guid id)
        {
            string example = "example";

            return Ok(example);
        }

        [HttpPost]
        public IActionResult CreateIngredient()
        {
            return Ok("object created");
        }

        [HttpPut("{id:guid}")]
        public IActionResult UpdateIngredient(Guid id)
        {
            return Ok("object updated");
        }

        [HttpDelete("{id:guid}")]
        public IActionResult DeleteIngredient(Guid id)
        {
            return Ok("object deleted");
        }
    }
}
