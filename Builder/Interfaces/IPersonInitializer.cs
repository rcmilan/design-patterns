using Domain.Interfaces;

namespace Builder.Interfaces
{
    public interface IPersonInitializer
    {
        // cada etapa retorna um método do tipo da etapa seguinte
        IPerson Create();
    }
}
