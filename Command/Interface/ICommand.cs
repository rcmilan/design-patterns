using Domain.Base;

namespace Command.Interface
{
    public interface ICommand<T, Id> where T : BaseModel<Id>
    {
        // Define o comando a ser executado
        void Execute();
    }
}
