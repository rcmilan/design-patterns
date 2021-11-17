using Bridge.ConcreteImplementations;
using Bridge.Implementations;
using Bridge.Models;
using Microsoft.AspNetCore.Mvc;

namespace DesignPatterns.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BridgeController : ControllerBase
    {
        [HttpGet("{theme}/Bike")]
        public ActionResult<Bike> GetBike([FromRoute] string theme)
        {
            // Bike recebe um esquema de cores
            ITheme selectedTheme;

            // Todos os esquemas possuem a mesma interface ITheme
            switch (theme)
            {
                case "Dark":
                    selectedTheme = new DarkTheme();
                    break;
                case "Light":
                    selectedTheme = new LightTheme();
                    break;
                case "Green":
                    selectedTheme = new GreenTheme();
                    break;
                default:
                    throw new Exception("Esquema de cores não encontrado");
            }

            // Bike recebe a interface ITheme
            // ITheme ja foi instanciada com um esquema de cores definido pelo usuário
            return new Bike(selectedTheme);
        }

        [HttpGet("{theme}/Furniture")]
        public Furniture GetFurniture([FromRoute] string theme)
        {
            ITheme selectedTheme = theme switch
            {
                "Dark" => new DarkTheme(),
                "Light" => new LightTheme(),
                "Green" => new GreenTheme(),
                _ => throw new Exception("Esquema de cores não encontrado"),
            };
            return new Furniture(selectedTheme);
        }
    }
}
