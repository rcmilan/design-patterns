using ChainOfResponsibility.Base;
using ChainOfResponsibility.Handlers;
using Domain.Base;
using Domain.Models;
using System;

namespace ChainOfResponsibility.ConcreteHandlers
{
    public class EngineHandler : BaseHandler<Car, Guid>
    {
        public override IHandler<Car, Guid> Handle(BaseModel<Guid> request)
        {
            if (request is Car car)
            {
                car.Engine = "Motor 123";
            }

            return base.Handle(request);
        }
    }
}
