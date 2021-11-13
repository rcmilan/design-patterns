using Command.Interface;
using Domain.Base;

namespace Command
{
    public class Invoker<T, Id> where T : BaseModel<Id>
    {
        // podemos executar vários commands
        private ICommand<T, Id> _onStart;
        private ICommand<T, Id> _onFinish;

        public void SetOnStart(ICommand<T, Id> command)
        {
            _onStart = command; // incializa command
        }
        public void SetOnFinish(ICommand<T, Id> command)
        {
            this._onFinish = command; // incializa command
        }

        // o Invoker não depende de commands concretos nem de classes receiver
        // o Invoker aciona o receiver indiretamente atravéz de um commands
        public void DoSomethingImportant()
        {
            if (this._onStart is ICommand<T, Id>)
            {
                this._onStart.Execute(); // executa command parametrizado primeiro
            }

            if (this._onFinish is ICommand<T, Id>)
            {
                this._onFinish.Execute(); // executa command parametrizado depois
            }
        }
    }
}
