using Microsoft.AspNetCore.Mvc;
using Prototype.Models;

namespace DesignPatterns.Controllers
{
    [Route("creational/[controller]")]
    [ApiController]
    public class PrototypeController : ControllerBase
    {
        [HttpGet]
        public ActionResult<Robot> Get()
        {
            var robot1 = new Robot
            {
                Color = "Red",
                Model = "Model 2",
                Type = "Type 1",
                Year = 2000
            };

            // o método clone vem de dentro da classe Robot
            // assim temos acesso a todos os seus campos
            var robot2 = (Robot)robot1.Clone();

            if (AreEqual(robot1, robot2))
                return Ok(robot2);

            return NoContent();
        }

        private bool AreEqual(Robot robot1, Robot robot2)
        {
            return robot1.Color == robot2.Color
                && robot1.Model == robot2.Model
                && robot1.Type == robot2.Type
                && robot1.Year == robot2.Year;
        }
    }
}
}
