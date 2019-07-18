using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_var3_task2
{
    class Program
    {
        static void Main(string[] args)
        {
            var int1 = new Interval(3, 10);
            Console.WriteLine("Создан первый интервал " + int1.Begin + "-" + int1.End);
            Console.WriteLine("Длина первого интервала " + int1.GetLenght());
            Console.WriteLine("Перегрузка орператора + (создаем новый интервал на основе первого путем увеличения второго поля)");
            Interval int2 = int1 + 5;
            Console.WriteLine(int2.Begin + " - " + int2.End);
            Console.WriteLine("Длина второго интервала " + int2.GetLenght());
            Console.WriteLine("Перегрузка орператора - (создаем новый интервал на основе первого путем уменьшения второго поля)");
            Interval int3 = int1 - 4;
            Console.WriteLine(int3.Begin + " - " + int3.End);
            Console.WriteLine("Длина третьего интервала " + int3.GetLenght());
            Console.WriteLine("Создаем пятый интервал путем инкремента второго поля первого интервала");
            Interval int5 = ++int1;
            Console.WriteLine("Пятый интервал лежит в промежутке " +int5.Begin + " - " + int5.End);
            Console.WriteLine("Создаем шестой интервал путем декремента второго поля первого интервала");
            Interval int6 = --int1;
            Console.WriteLine("Шестой интервал лежит в промежутке " + int6.Begin + " - " + int6.End);
            Console.WriteLine("Создаем седьмой интервал путем умножения кончного значения первого интервала");
            Interval int7 = int1 * 2;
            Console.WriteLine("Седьмой интервал создан " + int7.Begin + "-" + int7.End);
            Console.WriteLine("Сравниваем дину интервалов №1 и №2");
            Console.WriteLine("Интервал №1 " + int1.Begin + "-" + int1.End + "  и интервал №2 " + int2.Begin + "-" + int2.End );
            if (int1 == int2)
            {
                Console.WriteLine("Интервалы равны");
            }
            if (int1 != int2)
            {
                Console.WriteLine("Интервалы не равны");
            }
            Console.WriteLine("Выполняем неявное приведение типов");
            double x = int1.GetLenght();
            Interval int8 = (double)x;
            Console.WriteLine(int8.Begin + "-" + int8.End);

            Console.WriteLine(" Выполняем яыное приведение типов");
            double y;
            y = (double)int1;
            Console.WriteLine(y);
            Console.WriteLine(int1);

            Console.WriteLine(int1[0]);
            Console.WriteLine(int1[1]);

            if (int1)
            {
                Console.WriteLine("Длина интервала больше ноля");
            }
            Interval int10 = new Interval(0, 0);
       








        }
    }
}
