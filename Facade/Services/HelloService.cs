namespace Facade.Services
{
    internal class HelloService
    {
        public string HelloToUpper(string input) => input.Replace("hello", "HELLO");
    }
}
