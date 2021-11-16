using Microsoft.AspNetCore.Mvc;
using Strategy.Contexts;
using Strategy.Strategies;

namespace DesignPatterns.Controllers
{
    [Route("behavioral/[controller]")]
    [ApiController]
    public class StrategyController : ControllerBase
    {
        [HttpGet("sum")]
        public int Sum(int a, int b)
        {
            CalcContext context = new();

            context.SetStrategy(new CalcSum());

            return context.ExecuteStrategy(a, b);
        }

        [HttpGet("sub")]
        public int Sub(int a, int b)
        {
            CalcContext context = new();

            context.SetStrategy(new CalcSub());

            return context.ExecuteStrategy(a, b);
        }

        [HttpGet("mult")]
        public int Mult(int a, int b)
        {
            CalcContext context = new();

            context.SetStrategy(new CalcMult());

            return context.ExecuteStrategy(a, b);
        }
    }
}
