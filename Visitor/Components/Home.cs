using Visitor.Base;
using Visitor.Visitors;

namespace Visitor.Components;

public class Home : Place
{
    public int HomeFunction()
    {
        return 1;
    }

    public bool AnotherHomeFunction(bool source) => source;

    public override void Accept(IVisitor visitor)
    {
        if (visitor is Tourist)
            return;

        visitor.VisitHome(this);
    }
}