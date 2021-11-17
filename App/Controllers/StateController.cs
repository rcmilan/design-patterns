using Domain.Models;
using Microsoft.AspNetCore.Mvc;
using State.Contexts;
using State.States;

namespace DesignPatterns.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class StateController : ControllerBase
    {
        [HttpGet]
        public Document Get()
        {
            var context = new DocumentContext();

            context.UpdateDocument(); // created

            context.SetState(new ReadyState());

            context.UpdateDocument(); // ready

            return context;
        }
    }
}
