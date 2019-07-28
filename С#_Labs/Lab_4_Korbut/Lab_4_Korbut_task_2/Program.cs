using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;


namespace Lab_4_Korbut_task_2
{
    class Program
    {
        const string dirName = @"C:\Users\Korbut\Documents\BSUIR\Корбут\For_lab_4_C#";

        // Проверка на наличие файла с одинаковым имененм

        static bool FileNameCheck(string fileName)
        {
            string fileWay = dirName + fileName + ".txt";
            FileInfo file = new FileInfo(fileWay);
            if (file.Exists)
            {
                return true;
            }
            else return false;
        }

        static void Main(string[] args)
        {
            string fileName = null;
            while (true)
            {
                Console.WriteLine("\nВведите имя создаваемого файла, для записи в него информации о выбранном классе (по умолчанию класс Car)");
                fileName = Console.ReadLine();
                if (FileNameCheck(fileName))
                {
                    Console.WriteLine("\nФайл с таким именем уже существует! Попробуйте выбрать другое имя для файла");
                    continue;
                }
                else break;
            }
            Car newCar = new Car();
            newCar.wheelsNumber = 6;
            newCar.seats = 7;
            Type t = newCar.GetType();
            //Вызываем статический метод с записю инфо о классе в текстовый файл
            Car.WriteInfoFile(fileName, t);
        }
    }
}
