using Domain.Models;
using System;
using System.Drawing;

namespace Command
{
    // Receiver/Classe destinatário
    // o receiver pode ser qualquer classe com lógica de negócio
    public class Receiver
    {
        public void DoSomething(Car car, string _data)
        {
            car.Engine = _data;
            car.Color = Color.Red;
        }

        public void DoSomethingElse(Car car, string _data)
        {
            car.Model = _data;
            car.Year = DateTime.Now.Year;
        }
    }
}
