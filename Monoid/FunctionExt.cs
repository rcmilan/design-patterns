using Monoid.Structs;

namespace Monoid
{
    public static class FunctionExt
    {
        public static MFunction<T> Then<T>(this MFunction<T> thisM, MFunction<T> next) => new(x => thisM.Run(next.Run(x)));
    }
}