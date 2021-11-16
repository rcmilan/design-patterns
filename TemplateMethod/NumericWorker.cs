namespace TemplateMethod
{
    public class NumericWorker : Template<int>
    {
        public NumericWorker(List<int> values) : base(values)
        {
        }

        public override List<int> Sort()
        {
            return _values.OrderBy(n => n).ToList();
        }
    }
}
