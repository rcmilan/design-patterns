using Decorator.Components;
using System;
using System.Text;

namespace Decorator.Decorator
{
    /// <summary>
    /// Decorator base Concreto
    /// </summary>
    public class Base64Decorator : DataSourceDecorator
    {
        public Base64Decorator(IDataSource dataSource) : base(dataSource)
        {
        }

        public override string ReadData() => _wrapee.ReadData();

        public override void WriteData(string data) {

            var base64 = Convert.ToBase64String(Encoding.UTF8.GetBytes(data));

            _wrapee.WriteData(base64);
        }
    }
}
