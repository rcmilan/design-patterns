namespace Builder.Interfaces
{
    public interface IPersonNamingStage
    {
        // cada etapa retorna um método do tipo da etapa seguinte
        IPersonBirthDateStage SetName(string name);
    }
}
