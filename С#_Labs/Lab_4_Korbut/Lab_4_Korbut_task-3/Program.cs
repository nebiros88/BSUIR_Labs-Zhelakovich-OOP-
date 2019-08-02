using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4_Korbut_task_3
{
    class Program
    {
        // Вставить * после указанного символа
        static void AddStar(StringBuilder strbuilder)
        {
            char userSymbol = ' ';
            int matches = 0;
            Console.WriteLine("\nВведите символ после которого будет вставлена *");
            userSymbol = char.Parse(Console.ReadLine());
            for (int i = 0; i < strbuilder.Length; i++)
            {
                if (strbuilder[i] == userSymbol)
                {
                    strbuilder.Insert(i + 1, '*');
                    matches++;
                }
            }
            if (matches == 0)
            {
                Console.WriteLine("\nСовпадений по символу {0} не найдено", userSymbol);
            }
            else Console.WriteLine("\nВставка символа * выполнена успешно");
        }

        // Заменить один символ на другой
        static void RewriteSymbol(StringBuilder sb)
        {
            int matches = 0;
            Console.WriteLine("\nВведите символ который вы хотите заменить...");
            char x = char.Parse(Console.ReadLine());
            Console.WriteLine("\nВведите символ которым вы хотите заменить...");
            char y = char.Parse(Console.ReadLine());
            for (int i = 0; i < sb.Length; i++)
            {
                if (sb[i] == x)
                {
                    sb.Replace(x, y);
                    matches++;
                }
            }
            if (matches == 0)
            {
                Console.WriteLine("\nСовпадений по символу {0} не найдено", x);
            }
            else Console.WriteLine("\nЗамена указанного символа выполнена успешно");
        }

        // Удалить все вхождения указонной строк
        static void DeleteMatches(StringBuilder sb)
        {
            Console.WriteLine("\nВведите что следует удалить...");
            string userTxt = Console.ReadLine();
            List<int> index = null;
            string temp = sb.ToString();
            
           
        }
        static void Main(string[] args)
        {
            StringBuilder sb = null;
            while (true)
            {
                int choice = 0;
                Console.WriteLine("******************* Выберите действие **************");
                Console.WriteLine("1 - ввод строки с клавиатуры");
                Console.WriteLine("2 - вывод строки");
                Console.WriteLine("3 - после указанного символа каждый раз вставить *");
                Console.WriteLine("4 - заменить один символ на другой");
                Console.WriteLine("5 - удалить все вхождения указанной подстроки");
                Console.WriteLine("0 - выход");
                Console.WriteLine("****************************************************");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("\nВведите текст...");
                        sb = new StringBuilder(Console.ReadLine());
                        break;
                    case 2:
                        Console.WriteLine("\nВведенная вами строка - {0}.", sb);
                        break;
                    case 3:
                        AddStar(sb);
                        break;
                    case 4:
                        RewriteSymbol(sb);
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
