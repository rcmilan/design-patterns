using Domain.Base;
using Mediator.Base;
using Mediator.Interfaces;

namespace Mediator.Components
{
    public class Consumer<T> : BaseComponent<T>
    {
        public BaseModel<T> model;

        public Consumer(IMediator<T> mediator)
        {
            // só se acopla com o mediator
            this.mediator = mediator;
        }

        public override void Run(BaseModel<T> model)
        {
            this.model = mediator.Read(model);
        }
    }
}
