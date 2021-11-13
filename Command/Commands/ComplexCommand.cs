using Command.Interface;
using Domain.Models;
using System;

namespace Command.Commands
{
    public class ComplexCommand : ICommand<Car, Guid>
    {
        private Receiver _receiver;
        private Car _car;
        private string _data;

        public ComplexCommand(Receiver receiver, Car car, string data)
        {
            _receiver = receiver;
            _car = car;
            _data = data;
        }

        // realiza algo complexo
        public void Execute()
        {
            // aciona a lógica de negócio do receiver
            _receiver.DoSomething(_car, _data);
            _receiver.DoSomethingElse(_car, _data);
        }
    }
}
