using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Submarine : Ship
    {
        public int depth;
        public Submarine(int wheelsNumber, int seats, int depth) : base(wheelsNumber, seats, 0)
        {
            engineType = "electric";
            this.depth = depth;
        }

        public override string Loading(int fuel, int electricity)
        {
            if (electricity > 0) return "Я заправлен";
            if (fuel > 0) return "Для заправки подходит только электричество";
            return "Надо заправиться";
        }
        public override void print()
        {
            Console.WriteLine("Подводная лодка - обьект класса транспорт со след  полями ");
            Console.WriteLine("Тип двигателя -" + engineType);
            Console.WriteLine("Количестов колес -" + wheelsNumber);
            Console.WriteLine("Количество мест -" + seats);
            Console.WriteLine("Глубина погружения -" + depth);
        }

    }
}
