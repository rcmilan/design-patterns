using Interpreter.Base;

namespace Interpreter.Expressions
{
    public class HundredExpression : AbstractExpression
    {
        public override string One() { return "C"; }
        public override string Four() { return "CD"; }
        public override string Five() { return "D"; }
        public override string Nine() { return "CM"; }
        public override int Multiplier() { return 100; }
    }
}
