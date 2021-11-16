namespace Decorator.Components
{
    /// <summary>
    /// Componente Concreto
    /// </summary>
    public class FileDataSource : IDataSource
    {
        private string _data { get; set; }

        public string ReadData()
        {
            return _data;
        }

        public void WriteData(string data)
        {
            _data = data;
        }
    }
}
