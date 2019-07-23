using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab_4_Korbut
{
    class Program
    {
        const string dirName = @"D:\BSUIR\С#_Labs\Lab_4_Korbut";

        // Устанавливает текущий диск/каталог (по умолчанию конст переменная с имене path)
        static void MakeCurrent()
        {
            if (Directory.Exists(dirName))
            {
                Console.WriteLine("\nУстановлен текущий каталог {0}", dirName);
            }
            else Console.WriteLine("Произошла ошибка!");
        }

        // Вывести список всех каталогов в текущем (пронумерованный)

        static void GetAllDirectories()
        {
            string[] dirs = Directory.GetDirectories(dirName);
            Console.WriteLine("*****Список всех каталогов (пронумерованный)*****");
            for (int i = 0; i < dirs.Length; i++)
            {
                Console.WriteLine("{0} - {1}", i, dirs[i]);
            }
            Console.WriteLine("****************Завершено************************");
        }

        static void Main(string[] args)
        {
            int userChoice = 0;
            do
            {
                Console.WriteLine("------------------------------------------------");
                Console.WriteLine("|*******Главное меню, выберите действие********|");
                Console.WriteLine("| 1 - установить текущий диск/каталог          |");
                Console.WriteLine("| 2 - вывести список всех каталогов в текущем  |");
                Console.WriteLine("|     (пронумерованный)                        |");
                Console.WriteLine("| 3 - вывести список всех файлов в текущем     |");
                Console.WriteLine("|     каталоге (пронумерованный)               |");
                Console.WriteLine("| 4 - вывести на экран содержимое укзанного    |");
                Console.WriteLine("|     файла (по номеру)                        |");
                Console.WriteLine("| 5 - создать каталог в текущем                |");
                Console.WriteLine("| 6 - удалить каталог по номеру, если он пустой|");
                Console.WriteLine("| 7 - удалить файлы с указанными номерами      |");
                Console.WriteLine("| 8 - вывести список всех файлов с указанной   |");
                Console.WriteLine("|     датой создания (ищет в текущем каталоге  |");
                Console.WriteLine("|     и подкаталогах)                          |");
                Console.WriteLine("| 9 - выводит список всез текстовых файлов, в  |");
                Console.WriteLine("|     которых содержится указанный текст (ищет |");
                Console.WriteLine("|     в текущем каталоге и подкаталогах)       |");
                Console.WriteLine("| 0 - ВЫХОД                                    |");
                Console.WriteLine("------------------------------------------------");
                userChoice = int.Parse(Console.ReadLine());
                switch (userChoice)
                {
                    case 1:
                        MakeCurrent();
                        break;
                    case 2:
                        GetAllDirectories();
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 6:
                        break;
                    case 7:
                        break;
                    case 8:
                        break;
                    case 9:
                        break;
                    default: return;
                }
            }
            while (userChoice != 0);

        }
    }
}
