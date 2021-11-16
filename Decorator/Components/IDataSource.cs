using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Components
{
    /// <summary>
    /// Componente
    /// </summary>
    public interface IDataSource
    {
        void WriteData(string data);

        string ReadData();
    }
}
