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
        private static AutoResetEvent event_1 = new AutoResetEvent(false);
        private static AutoResetEvent event_2 = new AutoResetEvent(false);

        static void Main(string[] args)
        {
            Console.WriteLine("Нажмите Enter для создания и запуска двух потоков...");
            Console.ReadKey();
            Thread t = new Thread(ThreadProc1);
            t.Name = "Поток - 1";
            t.Start();
            Thread t1 = new Thread(ThreadProc2);
            t1.Name = "Поток - 2";
            t1.Start();
            Console.WriteLine($"Что бы запустить {t.Name} нажмите Enter...");
            Console.ReadKey();
            event_1.Set();
            Console.WriteLine($"Что бы запустить {t1.Name} нажмите Enter...");
            Console.ReadKey();
            event_2.Set();
            Thread thread3 = new Thread(new ParameterizedThreadStart(GetStarString));
            thread3.Start(5);
        }

        static void ThreadProc1()
        {
            string name = Thread.CurrentThread.Name;
            Console.WriteLine($"Поток с именем {name} ожидает AutoResetEvent #1");
            event_1.WaitOne();
            Values values1 = new Values(0, 20);
            values1.GetOddNumbers();
        }
        static void ThreadProc2()
        {
            string name = Thread.CurrentThread.Name;
            Console.WriteLine($"Поток с именем {name} ожидает AutoResetEvent #1");
            event_2.WaitOne();
            Values values2 = new Values(20, 40);
            values2.GetEvenNumbers();
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
