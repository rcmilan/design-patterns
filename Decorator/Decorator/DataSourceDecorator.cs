using Decorator.Components;

namespace Decorator.Decorator
{
    /// <summary>
    /// Decorator Base
    /// </summary>
    public abstract class DataSourceDecorator : IDataSource
    {
        protected IDataSource _wrapee;

        public DataSourceDecorator(IDataSource dataSource)
        {
            _wrapee = dataSource;
        }

        public abstract string ReadData();

        public abstract void WriteData(string data);
    }
}
