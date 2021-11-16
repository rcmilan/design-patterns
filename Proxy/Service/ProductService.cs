using Proxy.Interfaces;
using Proxy.Models;

namespace Proxy.Service
{
    public class ProductService : IPayment
    {
        public Product Pay(Product product)
        {
            // realzia o pagamento
            return product;
        }
    }
}
