using Currying;
using Microsoft.AspNetCore.Mvc;

namespace DesignPatterns.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CurryingController : ControllerBase
    {
        [HttpPost("subtractone")]
        public IActionResult SubtractOne(int number)
        {
            var result = CurryingFunctions.SubtractOne.Curry()(number);

            return Ok(result);
        }

        [HttpPost("add")]
        public IActionResult Add()
        {
            var result = CurryingFunctions.Add.Curry()(1)(2)(3)(4);

            return Ok(result);
        }
    }
}
