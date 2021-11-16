using Domain.Models;

namespace Singleton
{
    public class CarSingleton
    {
        // propriedade static para que a mesma instancia esteja disponivel para todo o sistema
        private static Car _car;

        // construtor é private para evitar que a classe seja instanciada
        private CarSingleton()
        {

        }

        /// <summary>
        /// Cria ou retorna a instancia do singleton
        /// </summary>
        /// <returns>Car</returns>
        public static Car GetInstance()
        {
            if (_car == null)
                _car = new Car { Model = "Singleton", Color = System.Drawing.Color.Black, Type = "Singleton" };

            return _car;
        }
    }
}
