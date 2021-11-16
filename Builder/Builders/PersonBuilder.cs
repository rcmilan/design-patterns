using Builder.Interfaces;
using Domain.Interfaces;
using Domain.Models;
using System;

namespace Builder.Builders
{
    // o Builder implementa todas as interfaces de suas etapas
    // permitindo retornar "this" após cada etapa
    public class PersonBuilder : IPersonInitializer, IPersonNamingStage, IPersonBirthDateStage, IPersonJobStage
    {
        // objeto que estamos criando
        private Person _person;

        // construtor privado
        // o builder não deve ser instanciado
        private PersonBuilder()
        {
            _person = new Person();
        }

        // como o builder não deve ser instanciado, utilizamos uma abordagem static para iniciar o fluxo
        public static IPersonNamingStage CreateNewPerson()
        {
            return new PersonBuilder();
        }

        // etapa final do fluxo, retorna o objeto criado
        // person implementa a interface IPerson
        // poderiamos também retornar o tipo concreto ao invéz da interface
        public IPerson Create()
        {
            return this._person;
        }

        // cada etapa retorna o tipo da etapa seguinte
        // assim, ao utilizar o builder, somos obrigados a seguir esta ordem
        public IPersonJobStage SetBirthDate(DateTime date)
        {
            _person.BirthDate = date;

            return this;
        }

        // cada etapa retorna o tipo da etapa seguinte
        // assim, ao utilizar o builder, somos obrigados a seguir esta ordem
        public IPersonInitializer SetJob(string job)
        {
            _person.Job = job;

            return this;
        }

        // cada etapa retorna o tipo da etapa seguinte
        // assim, ao utilizar o builder, somos obrigados a seguir esta ordem
        public IPersonBirthDateStage SetName(string name)
        {
            _person.FirstName = name;

            return this;
        }
    }
}
