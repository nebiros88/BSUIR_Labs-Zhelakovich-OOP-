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
        private static AutoResetEvent event_1 = new AutoResetEvent(true);
        private static AutoResetEvent event_2 = new AutoResetEvent(false);

        static void Main(string[] args)
        {
            Values values1 = new Values(0, 20);
            Values values2 = new Values(20, 40);
            //Thread thread1 = new Thread(new ThreadStart(values1.GetOddNumbers));
            //Thread thread2 = new Thread(new ThreadStart(values2.GetEvenNumbers));
            //Thread thread3 = new Thread(new ParameterizedThreadStart(GetStarString));
            //thread1.Start();
            //thread2.Start();
            Console.WriteLine("Нажмите Enter для создания и запуска двух потоков...");
            Console.ReadKey();
            for (int i = 1; i < 3; i++)
            {
                if (i == 1)
                {
                    Thread t = new Thread(ThreadProc);
                    t.Name = "Thread_" + i;
                    t.Start();
                }
            }


            Thread.Sleep(250);
            Thread thread3 = new Thread(new ParameterizedThreadStart(GetStarString));
            thread3.Start(5);

        }

        static void ThreadProc()
        {
            Values values1 = new Values(0, 20);
            new ThreadStart(values1.GetOddNumbers);
            string name = Thread.CurrentThread.Name;
            Console.WriteLine($"Поток с именем {name} ожидает AutoResetEvent #1");
            event_1.WaitOne();



            Console.WriteLine($"Поток с именем {name} освобожден от AutoResetEvent #1");

            Console.WriteLine($"Поток с именем {name} ожидает AutoResetEvent #2");
            event_2.WaitOne();
            Console.WriteLine($"Поток с именем {name} освобожден от AutoResetEvent #1");

            Console.WriteLine($"Поток с именем {name} окончен");
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
