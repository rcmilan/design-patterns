using System;

namespace Builder.Interfaces
{
    public interface IPersonBirthDateStage
    {
        // cada etapa retorna um método do tipo da etapa seguinte
        IPersonJobStage SetBirthDate(DateTime date);
    }
}
