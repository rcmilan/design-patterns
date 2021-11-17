using Flyweight.Models;
using Microsoft.AspNetCore.Mvc;

namespace DesignPatterns.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class FlyweightController : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<Tree>> Get()
        {
            var forest = new Forest();

            // Várias árvores possuem propriedades semalhantes
            // o Flyweight cria um objeto static com essas propriedades
            // assim várias árvores referenciam o mesmo objeto em memória
            // cada arvore vária apenas nas coordenadas

            forest.PlantTree(1, 2, "Arvore 1", "azul", "texture a");
            forest.PlantTree(3, 4, "Arvore 1", "azul", "texture a");
            forest.PlantTree(5, 6, "Arvore 2", "amarelo", "texture b");
            forest.PlantTree(5, 6, "Arvore 2", "amarelo", "texture b");

            return forest.Trees;
        }
    }
}
