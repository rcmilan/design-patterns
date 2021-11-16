namespace Visitor.Components;

public class ConcreteComponent1 : IComponent
{
    public void Accept(IVisitor visitor)
    {
        visitor.VisitConcreteComponent1(this);
    }


    public int SpecialMethodOfConcreteComponent1()
    {
        return 1;
    }
}