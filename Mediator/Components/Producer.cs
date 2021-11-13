using Domain.Base;
using Mediator.Base;
using Mediator.Interfaces;

namespace Mediator.Components
{
    public class Producer<T> : BaseComponent<T>
    {
        public Producer(IMediator<T> mediator)
        {
            // só se acopla com o mediator
            this.mediator = mediator;
        }

        public override void Run(BaseModel<T> model)
        {
            mediator.Store(model);
        }
    }
}
