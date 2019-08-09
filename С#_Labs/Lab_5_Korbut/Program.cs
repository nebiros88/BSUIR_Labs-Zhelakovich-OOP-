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
            newCar.DamageEngine += ShowMeesage;
            newCar.Accelerate(11);
        }

        public static void ShowMeesage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
