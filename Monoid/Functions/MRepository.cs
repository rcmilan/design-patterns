using Monoid.Structs;

namespace Monoid.Functions
{
    public static class MRepository
    {
        public static MFunction<int> Add5 => new(input => input + 5);
        public static MFunction<int> Add10 => new(input => input + 10);

        public static MFunction<ValueTuple<double, double, double>> Delta => new(input =>
        {
            double a = input.Item1;
            double b = input.Item2;
            double c = input.Item3;

            var delta = Math.Pow(b, 2) - 4 * a * c;

            return (input.Item1, input.Item2, delta);
        });

        public static MFunction<ValueTuple<double, double, double>> QuadraticResult => new(input =>
        {
            double a = input.Item1;
            double b = input.Item2;
            double delta = input.Item3;

            var x1 = (-b + Math.Sqrt(delta)) / (2 * a);
            var x2 = (-b - Math.Sqrt(delta)) / (2 * a);

            return (x1, x2, 0);
        });
    }
}
