using Visitor.Components;

namespace Visitor.Visitors
{
    public class Citizen : IVisitor
    {
        public int VisitHome(Home home)
        {
            return home.HomeFunction();
        }

        public string VisitPark(Park park)
        {
            return park.ParkFunction("B");
        }
    }
}
