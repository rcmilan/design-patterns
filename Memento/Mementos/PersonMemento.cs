using Domain.Models;
using Memento.Interfaces;
using System;

namespace Memento.Mementos
{
    public class PersonMemento : IMemento<Person, int>
    {
        private Person _state;

        // Memento concreto
        // possui a lógica para armazenar estado da classe criadora
        public PersonMemento(Person person)
        {
            // precisamos duma nova referência em memória
            // por isso criamos um novo objeto
            _state = new Person
            {
                Id = person.Id,
                BirthDate = person.BirthDate,
                FirstName = person.FirstName,
                LastName = person.LastName
            };
        }

        public DateTime GetDate()
        {
            return _state.BirthDate;
        }

        public string GetDescription()
        {
            return $"{_state.FirstName} {_state.LastName} - {_state.BirthDate:dd/MM/yyyy}";
        }

        public Person GetState()
        {
            return _state;
        }
    }
}
