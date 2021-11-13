using Domain.Models;

namespace Factory.Creators
{
    // Factory retorna um tipo concreto
    public interface ICarFactory
    {
        Car Create(string model, string color);
    }
}
