using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Car : Transport
    {
        public Car()
        {
            seats = 4; 
        }

        new public void Identify()                          //скрытие метода
        {
            Console.WriteLine("Я машина, я езжу");
        }

        public override void Refuel()
        {
            Console.WriteLine("Я заправляюсь бензином");
        }

        public override string Loading(int fuel, int electricity)
        {
            if (fuel > 0) return "Я заправлен";
            if (electricity > 0) return "Для заправки нужен только безин";
            return "Надо заправиться";

        }
        public override void print()
        {
            Console.WriteLine("машина - обьект класса транспорт с следующими  полями ");
            Console.WriteLine("Тип двигателя -" + engineType);
            Console.WriteLine("Количестов колес -" + wheelsNumber);
            Console.WriteLine("Количество мест -" + seats);
        }
    }
}
