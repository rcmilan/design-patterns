using Strategy.Interfaces;

namespace Strategy.Strategies
{
    public class CalcSub : IStrategy
    {
        public int Execute(int a, int b)
        {
            return a - b;
        }
    }
}
