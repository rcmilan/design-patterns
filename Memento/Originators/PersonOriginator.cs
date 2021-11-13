using Domain.Models;
using Memento.Interfaces;
using Memento.Mementos;
using System;

namespace Memento.Originators
{
    public class PersonOriginator
    {
        public Person _state;

        // originator guarda algum estado que pode variar ao longo do tempo
        public PersonOriginator(Person model)
        {
            _state = model;
        }

        public Person DoSomething()
        {
            _state.BirthDate = _state.BirthDate == DateTime.MinValue ? DateTime.Now : _state.BirthDate.AddYears(-1);

            return _state;
        }

        // guarda o estado atual dentro de um novo memento concreto
        public IMemento<Person, int> Save()
        {
            return new PersonMemento(_state);
        }

        public Person Restore(IMemento<Person, int> memento)
        {
            if (!(memento is PersonMemento))
            {
                throw new Exception("Memento desconhecido!");
            }

            _state = memento.GetState();

            return _state;
        }
    }
}
