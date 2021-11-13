using ChainOfResponsibility.Base;
using ChainOfResponsibility.Handlers;
using Domain.Base;
using Domain.Models;
using System;

namespace ChainOfResponsibility.ConcreteHandlers
{
    public class CarModelHandler : BaseHandler<Car, Guid>
    {
        public override IHandler<Car, Guid> Handle(BaseModel<Guid> request)
        {
            if (request is Car car)
            {
                car.Model = "Model Handler";
                car.Year = DateTime.Now.Year;
            }

            // chama o handler da superclasse
            return base.Handle(request);
        }
    }
}
