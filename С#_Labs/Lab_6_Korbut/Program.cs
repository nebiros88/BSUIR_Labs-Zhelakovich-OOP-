using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Lab_6_Korbut
{
    class Program
    {
        static void Main(string[] args)
        {
            Values values1 = new Values(0, 20);
            Values values2 = new Values(20, 40);
            Thread thread1 = new Thread(new ThreadStart(values1.GetOddNumbers));
            Thread thread2 = new Thread(new ThreadStart(values2.GetEvenNumbers));
            Thread thread3 = new Thread(new ParameterizedThreadStart(GetStarString));
            thread1.Priority = ThreadPriority.Normal;
            thread2.Priority = ThreadPriority.Lowest;
            thread1.Start();
            thread2.Start();
            thread3.IsBackground = true;
            thread3.Start(5);

        }

        static void GetStarString(object x)
        {
            for (int i = 1; i <= (int)x; i++)
            {
                Console.WriteLine(Stars(i));
            }
            for (int i = (int)x - 1; i > 0; i--)
            {
                Console.WriteLine(Stars(i));
            }
            Console.WriteLine("Поток 3 завершается");
        }

        static string Stars(int size)
        {
            return new string('*', size);
        }
    }
}
