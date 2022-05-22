using Microsoft.AspNetCore.Mvc;
using Monoid.Structs;

namespace DesignPatterns.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class MonoidController : ControllerBase
    {
        private static MFunction<int> Add5 => new(a => a + 5);
        private static MFunction<int> Add10 => new(a => a + 10);

        [HttpGet]
        public int AddInteger(int number)
        {
            var add15 = Add5 + Add10;

            return add15.Run(number);
        }
    }
}
