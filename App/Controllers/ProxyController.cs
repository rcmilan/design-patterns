using Microsoft.AspNetCore.Mvc;
using Proxy.Interfaces;
using Proxy.Models;
using Proxy.Proxies;
using Proxy.Service;

namespace DesignPatterns.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProxyController : ControllerBase
    {
        private IPayment _service;
        private IPayment _serviceProxy;

        public ProxyController()
        {
            _service = new ProductService();
            _serviceProxy = new LogProductService(_service);
        }

        [HttpPost("withoutProxy")]
        public ActionResult<Product> WithoutProxy(Product product)
        {
            _service.Pay(product);

            return product;
        }

        [HttpPost("withProxy")]
        public ActionResult<Product> WithProxy(Product product)
        {
            _serviceProxy.Pay(product);

            return product;
        }
    }
}
