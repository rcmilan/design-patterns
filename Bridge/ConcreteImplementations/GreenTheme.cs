using Bridge.Implementations;

namespace Bridge.ConcreteImplementations
{
    public class GreenTheme : ITheme
    {
        public string GetColor() => "Green";
    }
}