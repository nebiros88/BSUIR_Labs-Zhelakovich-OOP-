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
            newCar.SpeedExceed += newCar.ShowMessage;
            newCar.SpeedExceed += delegate (int n) { Console.WriteLine($"При скорости более {n} км/ч вы получите штраф!");};   // Анонимный делегат
            newCar.Accelerate(10);
            Console.WriteLine();
            newCar.AccelerateForMax(90);
            Console.WriteLine();
            Car raceCar = new Car("BMW", 200);
            raceCar.MaxSpeedReached += speedList =>         // Лямбда-выражение
            {
                int sum = 0;
                int result = 0;
                foreach (int val in raceCar.SpeedValues)
                {
                    sum += val;
                }
                result = sum / speedList.Capacity;
                Console.WriteLine($"Средняя скорость за время ускорение машины с именем -{raceCar.name}- составила -{result} км/ч");
                return result;
            };
            raceCar.AccelerateForMax(90);
        }

        public static void ShowMessage(string message)      //Статический метод любого класса
        {
            Console.WriteLine(message);
        }
    }
}
