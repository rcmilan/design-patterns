using Domain.Base;
using Mediator.Interfaces;

namespace Mediator.Base
{
    // fornece a implementação base para guardar o mediator nos componentes
    public abstract class BaseComponent<T>
    {
        protected IMediator<T> mediator;

        public abstract void Run(BaseModel<T> model);
    }
}
