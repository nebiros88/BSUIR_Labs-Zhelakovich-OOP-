using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Ship : Transport
    {
        public int displacement;
        public Ship(int wheelsNumber,int seats, int displacement)
        {
            this.wheelsNumber = wheelsNumber;
            this.seats =seats;
            this.displacement = displacement;
        }
        public override string Loading(int fuel, int electricity)
        {
            if (fuel > 0) return "Я заправлен";
            if (electricity > 0) return "Для заправки нужен только безин";
            return "Надо заправиться";
        }
        public override void print()
        {
            Console.WriteLine("Корабль - обьект класса транспорт со след  полями ");
            Console.WriteLine("Тип двигателя -" + engineType);
            Console.WriteLine("Количестов колес -" + wheelsNumber);
            Console.WriteLine("Количество мест -" + seats);
            Console.WriteLine("Водоизмещение -" + displacement);
        }
    }
}
