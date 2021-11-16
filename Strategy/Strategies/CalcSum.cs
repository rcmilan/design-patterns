using Strategy.Interfaces;

namespace Strategy.Strategies
{
    public class CalcSum : IStrategy
    {
        public int Execute(int a, int b)
        {
            return a + b;
        }
    }
}
