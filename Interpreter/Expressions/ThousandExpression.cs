using Interpreter.Base;

namespace Interpreter.Expressions
{
    public class ThousandExpression : AbstractExpression
    {
        public override string One() { return "M"; }
        public override string Four() { return " "; }
        public override string Five() { return " "; }
        public override string Nine() { return " "; }
        public override int Multiplier() { return 1000; }
    }
}
