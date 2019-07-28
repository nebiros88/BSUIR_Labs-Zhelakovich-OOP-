using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4_Korbut_task_2
{
    class Aircraft : Car
    {
        public int wings = 2;

        new public void Identify()
        {
           Console.WriteLine("Я самолет, я летаю");
        }
        public override void print()
        {
            Console.WriteLine("Самолет - обьект класса транспорт со след  полями ");
            Console.WriteLine("Тип двигателя -" + engineType);
            Console.WriteLine("Количестов колес -" + wheelsNumber);
            Console.WriteLine("Количество мест -" + seats);
            Console.WriteLine("Количество крыльев -" + wings);
        }
    }
}
