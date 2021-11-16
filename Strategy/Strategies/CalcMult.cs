using Strategy.Interfaces;

namespace Strategy.Strategies
{
    public class CalcMult : IStrategy
    {
        public int Execute(int a, int b)
        {
            return a * b;
        }
    }
}
