using Decorator.Components;
using Decorator.Decorator;
using Microsoft.AspNetCore.Mvc;

namespace DesignPatterns.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class DecoratorController : ControllerBase
    {
        [HttpGet("CAPSbase64")]
        public ActionResult<string> GetBase64UpperCase(string data)
        {
            var source = new FileDataSource();
            var upperCaseDecorator = new UpperCaseDecorator(source);
            var base64Decorator = new Base64Decorator(upperCaseDecorator);

            // o data será convertido em base 64
            // e em seguida em uppercase
            base64Decorator.WriteData(data);

            return source.ReadData();
        }


        [HttpGet("base64CAPS")]
        public ActionResult<string> GetUpperCaseBase64(string data)
        {
            // classe original
            var source = new FileDataSource();

            // os decorators "envelopam" a classe inicial
            // os decorators implementam a mesma interface da classe original
            // portanto também podem ser envelopados
            var base64Decorator1 = new Base64Decorator(source);
            var base64Decorator2 = new Base64Decorator(base64Decorator1);
            var base64Decorator3 = new Base64Decorator(base64Decorator2);
            var base64Decorator4 = new Base64Decorator(base64Decorator3);
            var base64Decorator5 = new Base64Decorator(base64Decorator4);
            var upperCaseDecorator = new UpperCaseDecorator(base64Decorator5);

            // aplica primeiro uppercase
            // depois aplica base64 5 vezes
            // a execução acontece de forma recursiva a partir do upperCaseDecorator
            upperCaseDecorator.WriteData(data);

            // o valor foi alterado no objeto original
            return source.ReadData();
        }
    }
}
