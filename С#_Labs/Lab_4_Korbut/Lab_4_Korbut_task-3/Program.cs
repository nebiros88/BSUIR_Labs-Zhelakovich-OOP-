using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4_Korbut_task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int choice = 0;
                Console.WriteLine("+++ Выберите действие +++");
                Console.WriteLine("1 - ввод строки с клавиатуры");
                Console.WriteLine("2 - вывод строки");
                Console.WriteLine("3 - после указанного символа каждый раз вставить *");
                Console.WriteLine("4 - заменить один символ на другой");
                Console.WriteLine("5 - удалить все вхождения указанной подстроки");
                Console.WriteLine("0 - выход");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    default: return;
                }
                if (choice < 0 || choice > 5)
                {
                    Console.WriteLine("Сделайте правильный выбор!");
                    continue;
                }
                else if (choice > 0 && choice < 6)
                {
                    continue;
                }
                else break;
            }
        }
    }
}
