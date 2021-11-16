using Domain.Models;
using Microsoft.AspNetCore.Mvc;
using Singleton;

namespace DesignPatterns.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class SingletonController : ControllerBase
    {
        [HttpGet]
        public ActionResult<Car> Get()
        {
            // busca a instancia dentro do singleton
            // todas as chamadas a GetInstance retornarão o mesmo objeto em memória
            var result = CarSingleton.GetInstance();

            return Ok(result);
        }
    }
}
