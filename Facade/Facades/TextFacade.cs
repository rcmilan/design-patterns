using Facade.Services;

namespace Facade.Facades
{
    /// <summary>
    /// Funciona como uma "fachada" para toda a lógica desta camada
    /// </summary>
    public class TextFacade
    {
        private HelloService _helloService;
        private WorldService _worldService;

        public TextFacade()
        {
            _helloService = new HelloService();
            _worldService = new WorldService();
        }

        public string Get(string text)
        {
            // a Facade tem acesso a vários services podendo combinar suas funções
            var result = _helloService.HelloToUpper(text);
            result = _worldService.WorldToUpper(result);

            return result;
        }
    }
}
