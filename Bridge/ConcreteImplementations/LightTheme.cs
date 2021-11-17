using Bridge.Implementations;
using System.Drawing;

namespace Bridge.ConcreteImplementations
{
    public class LightTheme : ITheme
    {
        public Color GetColor()
        {
            return Color.LightGray;
        }
    }
}