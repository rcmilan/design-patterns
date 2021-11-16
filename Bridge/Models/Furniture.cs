using Bridge.Implementations;

namespace Bridge.Models
{
    public class Furniture
    {
        protected ITheme theme;

        public Furniture(ITheme theme)
        {
            this.theme = theme;
        }

        public string Description => $"One {theme.GetColor()} Sofa";
    }
}

