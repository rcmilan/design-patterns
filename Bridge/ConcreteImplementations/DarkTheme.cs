using Bridge.Implementations;

namespace Bridge.ConcreteImplementations
{
    public class DarkTheme : ITheme
    {
        public string GetColor() => "Black";
    }
}