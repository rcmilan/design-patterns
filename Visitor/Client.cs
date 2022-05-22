using Visitor.Base;

namespace Visitor;

public class Client
{
    public static void VisitPlaces(List<Place> places, IVisitor visitor)
    {
        foreach (var place in places)
        {
            place.Accept(visitor);
        }
    }
}