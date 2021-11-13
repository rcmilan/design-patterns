using Domain.Interfaces;

namespace AbstractFactory.AbstractFactories
{
    // A Abstract Factory retorna uma série de produtos abstratos
    public interface IAbstractFactory
    {
        ICar CreateCar();
        IPerson CreatePerson();
    }
}
