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
        const string dirName = @"D:\BSUIR\Корбут\С#_Labs\Lab_4_Korbut";

        // Устанавливает текущий диск/каталог (по умолчанию конст переменная с имене dirName)
        static void MakeCurrent()
        {
            if (Directory.Exists(dirName))
            {
                Console.WriteLine("\nУстановлен текущий каталог {0}", dirName);
            }
            else Console.WriteLine("Произошла ошибка!");
        }

        // Вывести список всех каталогов в текущем (пронумерованный)

        static void ShowAllDirectories()
        {
            string[] dirs = Directory.GetDirectories(dirName);
            Console.WriteLine("*****Список всех каталогов (пронумерованный)*****");
            for (int i = 0; i < dirs.Length; i++)
            {
                Console.WriteLine("{0} - {1}", i, dirs[i]);
            }
            Console.WriteLine("****************Завершено************************");
        }

        // Вывести список всех айлов в текущм каталоге (пронумерованный)

        static void ShowAllFiles()
        {
            string[] dirs = Directory.GetFiles(dirName);
            Console.WriteLine("*****Список всех файлов (пронумерованный)*****");
            for (int i = 0; i < dirs.Length; i++)
            {
                Console.WriteLine("{0} - {1}", i, dirs[i]);
            }
            Console.WriteLine("****************Завершено************************");
        }

        // Вывести на экран содержимое указанного файла (по номеру)

        static void ShowFileContent()
        {
            int fileNumber = 0;
            string[] files = Directory.GetFiles(dirName);
            int conditionToContinue = 0;
            do
            {
                Console.WriteLine("\nВведите номер файла который вы хотите просмотреть");
                fileNumber = int.Parse(Console.ReadLine());
                if (fileNumber < 0 || fileNumber > files.Length - 1)
                {
                    Console.WriteLine("Файл под введенным вами номером не существует! Введите другой номер...");
                    conditionToContinue = 0;
                }
                else conditionToContinue = 1;

            }
            while (conditionToContinue == 0);
            if (conditionToContinue == 1)
            {
                Console.WriteLine("************Содержимое файла по номером {0} *********************", fileNumber);
                using (StreamReader sr = new StreamReader(files[fileNumber]))
                {
                    Console.WriteLine(sr.ReadToEnd());
                }
                Console.WriteLine("*****************Конец считанного файла***************************");
            }
        }

        // создание каталога в текущем

        static void CreateDirectory()
        {
            string newDirName = null;
            int contCondition = 0;
            string[] dirs = Directory.GetDirectories(dirName);
            do
            {
                Console.WriteLine("\nВведите имя создааваемого каталога");
                newDirName = Console.ReadLine();
                for (int i = 0; i < dirs.Length; i++)
                {
                    if (dirs[i] == newDirName)
                    {
                        Console.WriteLine("\nВведите другое имя создаваемого каталога");
                        contCondition = 0;
                    }
                    else contCondition = 1;
                }
            }
            while (contCondition == 0);
            if (contCondition == 1)
            {
                DirectoryInfo dirInfo = new DirectoryInfo(dirName);
                dirInfo.CreateSubdirectory(newDirName);
                Console.WriteLine("\nКаталог успешно создан");
            }
        }

        // Удаление каталога по номеру если он пустой

        static void DeleteDirIfEmpty()
        {
            string delDirName = null;
            int contCondition = 0;
            dynamic dirNumber = 0;
            string[] dirs = Directory.GetDirectories(dirName);
            DirectoryInfo dirInfo = new DirectoryInfo(dirName);
            do
            {
                Console.WriteLine("\nВведите номер директории для удаления");
                dirNumber = int.Parse(Console.ReadLine());
                if ((int)dirNumber < 0 || (int)dirNumber > dirs.Length)
                {
                    Console.WriteLine("\nВведите другой номер директории для удаления!");
                    contCondition = 0;
                }
                else
                {
                    contCondition = 1;
                    delDirName = dirs[(dirNumber];
                    dirInfo.Delete();
                }
            }
            while (contCondition == 0);
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
                        ShowAllDirectories();
                        break;
                    case 3:
                        ShowAllFiles();
                        break;
                    case 4:
                        ShowFileContent();
                        break;
                    case 5:
                        CreateDirectory();
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
