using Domain.Base;

namespace ChainOfResponsibility.Handlers
{
    public interface IHandler<T, Id> where T : BaseModel<Id>
    {
        // função para adicionar um handler na chain
        IHandler<T, Id> SetNext(IHandler<T, Id> handler);

        // função para executar o request
        IHandler<T, Id> Handle(BaseModel<Id> request);
    }
}
