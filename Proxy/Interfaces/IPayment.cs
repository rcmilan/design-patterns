using Proxy.Models;

namespace Proxy.Interfaces
{
    public interface IPayment
    {
        Product Pay(Product product);
    }
}
