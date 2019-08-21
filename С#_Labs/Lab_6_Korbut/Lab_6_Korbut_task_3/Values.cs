using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Lab_6_Korbut
{

    class Values
    {
        private int x;
        private int y;

        public Values(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        // Метод для вывода нечетных чисел
        public void GetOddNumbers()
        {
            for (int i = x; i <= y; i++)
            {
                if (i % 2 > 0)
                {
                    Console.WriteLine($"Нечетное число - {i}");
                }
            }
        }
        // Метод вывода четных чисел
        public void GetEvenNumbers()
        {
            for (int i = x; i <= y; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine($"Четное число - {i}");
                }
            }
        }
    }
}
