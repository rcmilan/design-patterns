using Proxy.Interfaces;
using Proxy.Models;

namespace Proxy.Proxies
{
    public class LogProductService : IPayment
    {
        private IPayment _service;

        public LogProductService(IPayment service)
        {
            _service = service;
        }

        public Product Pay(Product product)
        {
            LogPayment(product); // faz alguma coisa antes

            var result = _service.Pay(product);

            LogPayment(product); // faz alguma coisa depois

            return result;
        }

        private void LogPayment(Product product)
        {
            // realiza alguma coisa
            System.Console.WriteLine("log log log");
        }
    }
}
