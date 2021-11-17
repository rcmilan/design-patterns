using Composite.Composites;
using Composite.Models;
using Microsoft.AspNetCore.Mvc;

namespace DesignPatterns.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CompositeController : ControllerBase
    {
        [HttpGet("labels")]
        public ActionResult<string> GetLabels()
        {
            // Todos os produtos implementam a mesma interface IProduct
            var phone = new Phone("Telefone X");
            var computer = new Computer();
            var laptop = new Laptop("Laptop Y", 10m);

            // CompoundProduct também implementa IProduct
            var compoundProduct = new CompoundProduct();

            // CompoundProduct possui uma lista de produtos
            compoundProduct.Add(phone);
            compoundProduct.Add(computer);
            compoundProduct.Add(laptop);

            // por implementar IProduct
            // CompoundProduct pode executar os mesmo métodos dos outros produtos
            // CompoundProduct pode inclusive ser adicionado a uma lista de outro CompoundProduct formando uma árvore
            return compoundProduct.GetBrand();
        }

        [HttpGet("price")]
        public decimal GetTotalPrice()
        {
            var phone = new Phone("Telefone X");
            var computer = new Computer();
            var laptop = new Laptop("Laptop Y", 10m);

            var compoundProduct = new CompoundProduct();
            compoundProduct.Add(phone);
            compoundProduct.Add(computer);
            compoundProduct.Add(laptop);

            return compoundProduct.GetPrice();
        }
    }
}
