using Visitor.Base;
using Visitor.Visitors;

namespace Visitor.Components;

public class Park : Place
{
    public string ParkFunction(string parkName)
    {
        return $"Visitou o Parque {parkName}";
    }

    public override void Accept(IVisitor visitor)
    {
        visitor.VisitPark(this);
    }
}