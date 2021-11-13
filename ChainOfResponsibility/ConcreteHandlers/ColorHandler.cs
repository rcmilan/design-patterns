using ChainOfResponsibility.Base;
using ChainOfResponsibility.Handlers;
using Domain.Base;
using Domain.Models;
using System;
using System.Drawing;

namespace ChainOfResponsibility.ConcreteHandlers
{
    public class ColorHandler : BaseHandler<Car, Guid>
    {
        public override IHandler<Car, Guid> Handle(BaseModel<Guid> request)
        {
            if (request is Car car)
            {
                car.Color = Color.Green;
            }

            // chama o handler da superclasse
            return base.Handle(request);
        }
    }
}
