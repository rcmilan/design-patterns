using AbstractFactory.AbstractFactories;
using Domain.Interfaces;
using Domain.Models;
using System;
using System.Drawing;

namespace AbstractFactory.ConcreteFactories
{
    public class VintageFactory : IAbstractFactory
    {
        public ICar CreateCar()
        {
            return new Car { Model = "Vintage 2", Color = Color.Red, Type = "Old" };
        }

        public IPerson CreatePerson()
        {
            return new Person { FirstName = "Vintage Person Sr.", BirthDate = DateTime.Now, Job = "Old Labour" };
        }
    }
}
