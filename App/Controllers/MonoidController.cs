using Microsoft.AspNetCore.Mvc;
using Monoid.Functions;
using Monoid.Structs;

namespace DesignPatterns.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class MonoidController : ControllerBase
    {
        public record QuadraticResult(double X1, double X2);

        [HttpGet("quadratic")]
        public QuadraticResult Quadratic(double a, double b, double c)
        {
            var calculate = MRepository.QuadraticResult + MRepository.Delta;

            var res = calculate.Run((a, b, c));

            return new QuadraticResult(res.Item1, res.Item2);
        }

        [HttpGet("sum")]
        public int SumInteger(int number)
        {
            var add15 = MRepository.Add5 + MRepository.Add10;

            return add15.Run(number);
        }
    }
}
