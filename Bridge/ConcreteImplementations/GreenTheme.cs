using Bridge.Implementations;
using System.Drawing;

namespace Bridge.ConcreteImplementations
{
    public class GreenTheme : ITheme
    {
        public Color GetColor()
        {
            return Color.Green;
        }
    }
}