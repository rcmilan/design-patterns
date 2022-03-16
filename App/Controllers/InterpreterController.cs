using Interpreter;
using Interpreter.Base;
using Interpreter.Expressions;
using Microsoft.AspNetCore.Mvc;

namespace DesignPatterns.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class InterpreterController : ControllerBase
    {
        [HttpPost]
        public ActionResult<int> Post(string roman)
        {
            Context context = new(roman);

            List<AbstractExpression> tree = new()
            {
                new ThousandExpression(),
                new HundredExpression(),
                new TenExpression(),
                new OneExpression()
            };

            // Interpret            
            foreach (AbstractExpression exp in tree)
            {
                exp.Interpret(context);
            }

            return Ok(context.Output);
        }
    }
}
