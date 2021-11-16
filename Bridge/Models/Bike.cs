using Bridge.Implementations;

namespace Bridge.Models
{
    public class Bike
    {
        protected ITheme theme;

        public Bike(ITheme theme)
        {
            this.theme = theme;
        }

        public string Description => $"{theme.GetColor()} Bike";
    }
}