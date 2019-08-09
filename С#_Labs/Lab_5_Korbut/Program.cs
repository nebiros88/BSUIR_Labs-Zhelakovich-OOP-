using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5_Korbut
{
    class Program
    {
        static void Main(string[] args)
        {
            Car newCar = new Car("Ford", 180);
            newCar.DamageEngine += ShowMessage;
            newCar.Accelerate(10);
        }

        public static void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
