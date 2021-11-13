using ChainOfResponsibility.Handlers;
using Domain.Base;

namespace ChainOfResponsibility.Base
{
    // Handler abstrato, fornece a implementação padrão
    public abstract class BaseHandler<T, Id> : IHandler<T, Id> where T : BaseModel<Id>
    {
        private IHandler<T, Id> _next { get; set; }

        public virtual IHandler<T, Id> Handle(BaseModel<Id> request)
        {
            if (this._next != null)
                return this._next.Handle(request); // chama o próximo handler
            else
                return null;
        }

        public IHandler<T, Id> SetNext(IHandler<T, Id> handler)
        {
            _next = handler;

            // retornar o handler nos permite encadedar várias chamadas
            // objeto1.SetNext(objeto2).SetNext(objeto3).SetNext(objeto4) ...
            return handler;
        }
    }
}
