using Bridge.Implementations;
using System.Drawing;

namespace Bridge.ConcreteImplementations
{
    public class DarkTheme : ITheme
    {
        public Color GetColor()
        {
            return Color.Black;
        }
    }
}