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
            Task<string> task1 = Task<string>.Factory.StartNew(() => GetStarString(5));
            Console.WriteLine(task1.Result);
            var outer = Task.Factory.StartNew(() =>
            {
                values1.GetOddNumbers();
                var inner = Task.Factory.StartNew(() =>
                {
                    values2.GetEvenNumbers();
                },TaskCreationOptions.AttachedToParent);        //Выполнение вложенной задачи вместе с внешней
            });
            outer.Wait();
        }

        static string GetStarString(object x)
        {
            for (int i = 1; i <= (int)x; i++)
            {
               Console.WriteLine(Stars(i));
            }
            for (int i = (int)x - 1; i > 0; i--)
            {
                Console.WriteLine(Stars(i));
            }
            return "Конец 3-го метода";
        }

        static string Stars(int size)
        {
            return new string('*', size);
        }
    }
}
