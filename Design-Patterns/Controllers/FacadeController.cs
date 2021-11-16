using Facade.Facades;
using Microsoft.AspNetCore.Mvc;

namespace DesignPatterns.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class FacadeController : ControllerBase
    {
        private readonly TextFacade _service;

        public FacadeController()
        {
            _service = new TextFacade();
        }

        [HttpGet]
        public ActionResult<string> Index()
        {
            // Facade simplifica o acesso a lógica de negócio da camada
            return _service.Get("hello world!");
        }
    }
}
