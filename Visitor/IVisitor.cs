using Visitor.Components;

namespace Visitor;

public interface IVisitor
{
    string VisitPark(Park park);
    int VisitHome(Home home);
}