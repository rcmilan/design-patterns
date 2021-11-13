using AbstractFactory.AbstractFactories;
using Domain.Interfaces;
using Domain.Models;
using System;
using System.Drawing;

namespace AbstractFactory.ConcreteFactories
{
    public class ModernFactory : IAbstractFactory
    {
        public ICar CreateCar() => new Car { Model = "Modern Modern", Color = Color.Blue, Type = "Modern" };

        public IPerson CreatePerson() => new Person { Name = "Modern Person Jr.", BirthDate = DateTime.Now, Job = "Modern Job" };
    }
}
