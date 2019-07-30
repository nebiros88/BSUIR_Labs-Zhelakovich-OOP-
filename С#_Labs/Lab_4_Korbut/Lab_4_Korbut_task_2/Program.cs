using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;
using System.Runtime.Serialization.Formatters.Binary;


namespace Lab_4_Korbut_task_2
{
    class Program
    {
        const string dirName = @"d:\BSUIR\Directory_for_lab_4\";

        // Проверка на наличие файла с одинаковым имененм

        static bool FileNameCheckTxt(string fileName)
        {
            string fileWay = dirName + fileName;
            FileInfo file = new FileInfo(fileWay);
            if (file.Exists)
            {
                return true;
            }
            else return false;
        }

        // Запрос пользавателю на выбор имени для создаваемого файла
        static string RequestFileName(string userFileName)
        {
            while (true)
            {
                Console.WriteLine("\nВведите имя создаваемого файла");
                userFileName = Console.ReadLine();
                if (FileNameCheckTxt(userFileName))
                {
                    Console.WriteLine("\nФайл с таким именем уже существует! Попробуйте выбрать другое имя для файла");
                    continue;
                }
                else break;
            }
            Console.WriteLine("******Имя файла успешно задано*****");
            return userFileName;
        }
        static void Main(string[] args)
        {
            string userFileName = null;
            int userChoice = 0;
            Car newCar = new Car("FORD", 6);
            newCar.wheelsNumber = 6;
            Type t = newCar.GetType();
            while (true)
            {
                Console.WriteLine("******************Меню*************************");
                Console.WriteLine("*1 - Запись всей информации о типе класса Car *");
                Console.WriteLine("*    (рефлексия). Имя файла - параметр метода *");
                Console.WriteLine("*2 - Сохранение в бинарный файл иформацию о   *");
                Console.WriteLine("*    текущем обьекте. Имя файла - параметр    *");
                Console.WriteLine("*    метода.                                  *");
                Console.WriteLine("*3 - прочитать информацию из бинарного файла  *");
                Console.WriteLine("*    и возвратить готовый обьект. Имя файла - *");
                Console.WriteLine("*    параметр метода.                         *");
                Console.WriteLine("*4 - выполнение сериализации и десериализации *");
                Console.WriteLine("*    обьектов класса. Имя - параметр метода   *");
                Console.WriteLine("*0 - ВЫХОД                                    *");
                Console.WriteLine("***********************************************");
                userChoice = int.Parse(Console.ReadLine());
                switch (userChoice)
                {
                    case 1:
                        userFileName = RequestFileName(userFileName);
                        Car.WriteInfoFile(userFileName, t);
                        break;
                    case 2:
                        userFileName = RequestFileName(userFileName);
                        newCar.WriteBinaryInfoFile(userFileName);
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    default: return;
                }
                if (userChoice > 0 && userChoice <= 4)
                {
                    continue;
                }
                else break;
            }
        }
    }
}
