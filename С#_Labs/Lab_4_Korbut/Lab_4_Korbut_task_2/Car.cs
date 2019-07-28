using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;

namespace Lab_4_Korbut_task_2
{
    class Car : Transport
    {
        public Car()
        {
            seats = 4; 
        }

        new public void Identify()                          //скрытие метода
        {
            Console.WriteLine("Я машина, я езжу");
        }

        public override void Refuel()
        {
            Console.WriteLine("Я заправляюсь бензином");
        }

        public override string Loading(int fuel, int electricity)
        {
            if (fuel > 0) return "Я заправлен";
            if (electricity > 0) return "Для заправки нужен только безин";
            return "Надо заправиться";

        }
        public override void print()
        {
            Console.WriteLine("машина - обьект класса транспорт с следующими  полями ");
            Console.WriteLine("Тип двигателя -" + engineType);
            Console.WriteLine("Количестов колес -" + wheelsNumber);
            Console.WriteLine("Количество мест -" + seats);
        }
        // Метод записи информации о классе в текстовый файл имя которого передается параметром
        public static void WriteInfoFile(string fileName, Type t)
        {
            string newFileFolder = @"C:\Users\Korbut\Documents\BSUIR\Корбут\For_lab_4_C#\" + fileName + ".txt";
            //FileInfo infoFile = new FileInfo(newFileFolder);
            File.Create(newFileFolder);
            try
            {
                using (StreamWriter sw = new StreamWriter(newFileFolder, true, System.Text.Encoding.Default))
                {
                    sw.Write("Полное имя класса - " + t.FullName);
                    if (t.IsAbstract) sw.Write("Абстрактный класс");
                    if (t.IsClass) sw.Write("Обычный класс");
                    if (t.IsEnum) sw.Write("Перечисление");
                    if (t.IsInterface) sw.Write("Интерфейс");
                    if (t.IsPrimitive) sw.Write("Примитив");
                    if (t.IsSealed) sw.Write("Закрыт для наледования");
                    sw.Write("Базовый класс - " + t.BaseType);
                    sw.Write("++++++++ ПОЛЯ КЛАССА +++++++++");
                    FieldInfo[] m = t.GetFields();
                    foreach (FieldInfo x in m)
                    {
                        sw.Write(x);
                    }
                    sw.Write("+++++++ СВОЙСТВА КЛАССА +++++++++");
                    PropertyInfo[] m1 = t.GetProperties();
                    foreach (PropertyInfo x in m1)
                    {
                        sw.Write(x);
                    }
                    sw.Close();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
