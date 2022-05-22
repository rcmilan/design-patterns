namespace Monoid.Structs
{
    public struct MFunction<T>
    {
        public Func<T, T> Run;

        public MFunction(Func<T, T> fn) => Run = fn;

        public MFunction<T> Then(MFunction<T> next)
        {
            var runCopy = Run;

            return new(x => runCopy(next.Run(x)));
        }

        public static MFunction<T> operator +(MFunction<T> left, MFunction<T> right)
        {
            return new(x => left.Run(right.Run(x)));
        }
    }
}
