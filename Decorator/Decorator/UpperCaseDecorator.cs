using Decorator.Components;

namespace Decorator.Decorator
{
    /// <summary>
    /// Decorator Concreto
    /// </summary>
    public class UpperCaseDecorator : DataSourceDecorator
    {
        public UpperCaseDecorator(IDataSource dataSource) : base(dataSource)
        {
        }

        public override string ReadData()
        {
            return _wrapee.ReadData();
        }

        public override void WriteData(string data)
        {
            _wrapee.WriteData(data.ToUpper());
        }
    }
}
