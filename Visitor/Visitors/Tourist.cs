using Visitor.Components;

namespace Visitor.Visitors
{
    public class Tourist : IVisitor
    {
        public int VisitHome(Home home)
        {
            return home.AnotherHomeFunction(true) ? 1 : 0;
        }

        public string VisitPark(Park park)
        {
            return park.ParkFunction("A");
        }
    }
}
