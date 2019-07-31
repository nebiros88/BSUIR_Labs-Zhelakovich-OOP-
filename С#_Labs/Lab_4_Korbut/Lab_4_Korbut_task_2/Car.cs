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
    [Serializable]
    class Car : Transport
    {
        public Car(string carName, int carSeats)
        {
            this.name = carName;
            this.seats = carSeats;
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
        public override void Print()
        {
            Console.WriteLine("машина - обьект класса транспорт с следующими  полями ");
            Console.WriteLine("Имя машины - " + name);
            Console.WriteLine("Тип двигателя -" + engineType);
            Console.WriteLine("Количестов колес -" + wheelsNumber);
            Console.WriteLine("Количество мест -" + seats);
        }
        // Метод записи информации о классе в текстовый файл имя которого передается параметром
        public static void WriteInfoFile(string fileName, Type t)
        {
            string newFileFolder = @"d:\BSUIR\Directory_for_lab_4\" + fileName + ".txt";
            try
            {
                using (StreamWriter sw = new StreamWriter(newFileFolder, true, System.Text.Encoding.Default))
                {
                    sw.Write("Полное имя класса - " + t.FullName);
                    sw.Write("\n");
                    if (t.IsAbstract) sw.Write("Абстрактный класс");
                    if (t.IsClass) sw.Write("Обычный класс");
                    if (t.IsEnum) sw.Write("Перечисление");
                    if (t.IsInterface) sw.Write("Интерфейс");
                    if (t.IsPrimitive) sw.Write("Примитив");
                    if (t.IsSealed) sw.Write("Закрыт для наледования");
                    sw.Write("\n");
                    sw.Write("Базовый класс - " + t.BaseType);
                    sw.Write("\n");
                    sw.Write("++++++++ ПОЛЯ КЛАССА +++++++++");
                    sw.Write("\n");
                    FieldInfo[] m = t.GetFields();
                    foreach (FieldInfo x in m)
                    {
                        sw.Write(x);
                        sw.Write("\n");
                    }
                    sw.Write("+++++++ СВОЙСТВА КЛАССА +++++++++");
                    sw.Write("\n");
                    PropertyInfo[] m1 = t.GetProperties();
                    foreach (PropertyInfo x in m1)
                    {
                        sw.Write(x);
                        sw.Write("\n");
                    }
                    sw.Close();
                }
                Console.WriteLine("+++++ Текстовый файл успешно создан +++++");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        // Экземплярный метод для сохранения всей информации о обьекте в бинарный файл
        public void WriteBinaryInfoFile(string fileName)
        {
            string newFileFolder = @"d:\BSUIR\Directory_for_lab_4\" + fileName + ".bin";
            FileStream fs = new FileStream(newFileFolder, FileMode.OpenOrCreate, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);
            bw.Write(name);
            bw.Write(seats);
            bw.Write(engineType);
            bw.Write(wheelsNumber);
            bw.Close();
            Console.WriteLine("+++++ Бинарный файл успешно создан +++++");
        }

        // Метод для создания обьекта на основе считывания данныз из бинарного файла
        public static Car ReadFromBinaryToCreate(string fileName)
        {
            string newFileFolder = @"d:\BSUIR\Directory_for_lab_4\" + fileName + ".bin";
            FileStream fs = new FileStream(newFileFolder, FileMode.OpenOrCreate, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            string name = br.ReadString();
            int seats = br.ReadInt32();
            string engineType = br.ReadString();
            int wheelsNumber = br.ReadInt32();
            Car newCar = new Car(name, seats);
            return newCar;
        }

        // Метод сериализующий укащанный обьект
        public void Serialize(string fileName)
        {
            string fileFolder = @"d:\BSUIR\Directory_for_lab_4\" + fileName + ".dat";
            FileStream fs = new FileStream(fileFolder, FileMode.Create);
            BinaryFormatter fm = new BinaryFormatter();
            try
            {
                fm.Serialize(fs, this);
            }
            catch (Exception e)
            {
                Console.WriteLine("Сериализация не удалась по следующей причине" + e.Message);
                throw;
            }
            finally
            {
                fs.Close();
                Console.WriteLine("Сериализация обьекта прощла успешно");
            }
        }

        // Метод для десериализации выбранного обьект
        public static void DeSerialize(Car newCar, string fileName)
        {
            string fileFolder = @"d:\BSUIR\Directory_for_lab_4\" + fileName + ".dat";
            FileStream fs = new FileStream(fileFolder, FileMode.Open);
            BinaryFormatter fm = new BinaryFormatter();
            try
            {
                newCar = (Car)fm.Deserialize(fs);
            }
            catch (Exception e)
            {
                Console.WriteLine("Десериализация не выполнена по причине - " + e.Message);
            }
            finally
            {
                fs.Close();
                Console.WriteLine("******************************");
                Console.WriteLine("Десериализация прошла успешно ");
                Console.WriteLine("Создан обьект");
                newCar.Print();
                Console.WriteLine("******************************");
            }
        }

    }
}
