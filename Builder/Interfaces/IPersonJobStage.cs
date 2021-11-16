namespace Builder.Interfaces
{
    public interface IPersonJobStage
    {
        // cada etapa retorna um método do tipo da etapa seguinte
        IPersonInitializer SetJob(string job);
    }
}
