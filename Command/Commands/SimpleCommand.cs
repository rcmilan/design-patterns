using Command.Interface;
using Domain.Models;

namespace Command.Commands
{
    public class SimpleCommand : ICommand<Person, int>
    {
        private Person _payload;

        public SimpleCommand(Person payload)
        {
            _payload = payload;
        }

        // realiza algo simples
        public void Execute()
        {
            _payload.FirstName = "Simple";
            _payload.LastName = "Command";
        }
    }
}
