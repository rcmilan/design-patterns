using Visitor.Components;

namespace Visitor;

public interface IVisitor
{
    string VisitConcreteComponentA(ConcreteComponentA concreteComponentA);
    int VisitConcreteComponent1(ConcreteComponent1 concreteComponent1);
}