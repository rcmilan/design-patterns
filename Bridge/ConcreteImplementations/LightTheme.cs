using Bridge.Implementations;

namespace Bridge.ConcreteImplementations
{
    public class LightTheme : ITheme
    {
        public string GetColor() => "Light Blue";
    }
}