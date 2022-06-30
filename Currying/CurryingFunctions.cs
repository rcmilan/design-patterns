namespace Currying
{
    public static class CurryingFunctions
    {
        public static Func<int, int> SubtractOne = x => x - 1;
        public static Func<int, int, int, int, int> Add = (w, x, y, z) => w + x + y + z;

        public static Func<TInput1, TOutput> Curry<TInput1, TOutput>(this Func<TInput1, TOutput> f)
        {
            return x => f(x);
        }
        public static Func<TInput1, Func<TInput2, Func<TInput3, Func<TInput4, TOutput>>>> Curry<TInput1, TInput2, TInput3, TInput4, TOutput>(this Func<TInput1, TInput2, TInput3, TInput4, TOutput> f)
        {
            return w => x => y => z => f(w, x, y, z);
        }
    }
}