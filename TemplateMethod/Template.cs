namespace TemplateMethod
{
    public abstract class Template<T>
    {
        public List<T> _values;

        public Template(List<T> values)
        {
            _values = values;
        }

        public abstract List<T> Sort();

        public List<T> Get()
        {
            return _values;
        }
    }
}