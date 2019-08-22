using Lab_3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3_Task_6
{
    class Program
    {
        private static List<Vehicle> vehicleCollection;
        const int defaultUserChoice = -1;
        const int aircraftType = 1;
        const int amphibianType = 2;

        static void ShowAll()                                       // просмотр коллекции
        {
            Console.WriteLine("---------------------------------------------------------------------");
            foreach (Vehicle craft in vehicleCollection)
            {
                craft.Print1();
            }
            Console.WriteLine("---------------------------------------------------------------------");
        }

        static bool SearchSame(string value)                          // проверка на совпадение имен
        {
            foreach (Vehicle craft in vehicleCollection)
            {
                if (craft.name == value)
                {
                    return true;
                }
            }
            return false;
        }

        static void AddNewObject()               // добавление элемента (конструктор с двумя параметрами)
        {
            Vehicle newCraft = null;
            string objectName = null;
            int continueCondition = 1;
            double objectWeight = 0;
            do
            {
                Console.WriteLine("Введите имя обьекта...");
                objectName = Console.ReadLine();
                if (SearchSame(objectName))
                {
                    Console.WriteLine("Выбранное вами имя уже существует!");
                    continueCondition = 0;
                }
                else continueCondition = 1;
            }
            while (continueCondition == 0);
            if (continueCondition == 1)
            {
                Console.WriteLine("Введите массу обьекта...");
                objectWeight = double.Parse(Console.ReadLine());
                Console.WriteLine("Выберите тип создаваемого обьекта...");
                Console.WriteLine("*1 - самолет                       *");
                Console.WriteLine("*2 - самолет-амфибия               *");
                int typeChoice = int.Parse(Console.ReadLine());
                if (typeChoice == aircraftType)
                {
                    newCraft = new Aircraft(objectName, objectWeight);
                }
                else if (typeChoice == amphibianType)
                {
                    newCraft = new Amphibian(objectName, objectWeight);
                }
                else throw new Exception("Выбран не верный тип создаваемого обьекта");
                vehicleCollection.Add(newCraft);
            }
        }

        static bool IndexCheck(int value)                           //  проверка по индексу коллекции
        {
            if (value < 0 || value > vehicleCollection.Count - 1)
            {
                return true;
            }
            else return false;
        }

        static void AddByIndex()                                    // добавление элемента по индексу
        {
            Vehicle newCraft = null;
            string objectName = null;
            int continueCondition = 1;
            double objectWeight = 0;
            int craftIndex = 0;
            do
            {
                Console.WriteLine("Введите индекс добавляемого обьекта...");
                craftIndex = int.Parse(Console.ReadLine());
                if (IndexCheck(craftIndex))
                {
                    Console.WriteLine("Не верный индекс!");
                    continueCondition = 0;
                }
                else
                {
                    Console.WriteLine("Введите имя обьекта...");
                    objectName = Console.ReadLine();
                    if (SearchSame(objectName))
                    {
                        Console.WriteLine("Выбранное вами имя уже существует!");
                        continueCondition = 0;
                    }
                    else continueCondition = 1;
                }
            }
            while (continueCondition == 0);
            if (continueCondition == 1)
            {
                Console.WriteLine("Введите массу обьекта...");
                objectWeight = double.Parse(Console.ReadLine());
                Console.WriteLine("Выберите тип создаваемого обьекта...");
                Console.WriteLine("*1 - самолет                       *");
                Console.WriteLine("*2 - самолет-амфибия               *");
                int typeChoice = int.Parse(Console.ReadLine());
                if (typeChoice == aircraftType)
                {
                    newCraft = new Aircraft(objectName, objectWeight);
                }
                else if (typeChoice == amphibianType)
                {
                    newCraft = new Amphibian(objectName, objectWeight);
                }
                else throw new Exception("Выбран не верный тип создаваемого обьекта");
                vehicleCollection.Insert(craftIndex, newCraft);
            }
        }

        static void FirstElement()                                        // элемент с начала коллекции
        {
            Console.WriteLine("Элемент с начала коллекции");
            Console.WriteLine(vehicleCollection.First<Vehicle>());
            vehicleCollection[0].Print1();
        }

        static void LastElement()                                        // элемент с конца коллекции
        {
            Console.WriteLine("Элемент с конца коллекции");
            Console.WriteLine(vehicleCollection.Last<Vehicle>());
            vehicleCollection[vehicleCollection.Count - 1].Print1();
        }

        static void DellByIndex()                                       // удаление элемента по индексу
        {
            int craftIndex = 0;
            int continueCondition = 1;
            do
            {
                Console.WriteLine("Введите индекс удаляемого обьекта...");
                craftIndex = int.Parse(Console.ReadLine());
                if (IndexCheck(craftIndex))
                {
                    Console.WriteLine("Вы ввели не правильный индекс");
                    continueCondition = 0;
                }
                else continueCondition = 1;
            }
            while (continueCondition == 0);
            if (continueCondition == 1)
            {
                vehicleCollection.RemoveAt(craftIndex);
                Console.WriteLine("Элемент по куазанному индексу успешно удален");
            }
        }

        static void DellByValue()                                       // удаление элемента по значению
        {
            int continueCondition = 1;
            string userData = null;
            do
            {
                Console.WriteLine("Введите значение (для дальнейшего удаления из коллекции при совпадении)");
                userData = Console.ReadLine();
                if (!SearchSame(userData))
                {
                    Console.WriteLine("Совпадений не найдено!");
                    continueCondition = 0;
                }
                else continueCondition = 1;
            }
            while (continueCondition == 0);
            if (continueCondition == 1)
            {
                vehicleCollection.RemoveAll(Vehicle => Vehicle.name == userData);
                Console.WriteLine("Все уэлементы с данным совпадением удалены");
            }
        }

        static void ReverseCollection()                             // реверс коллекции
        {
            vehicleCollection.Reverse();
            Console.WriteLine("Реверс коллекции выполнен");
        }

        static void SortCollection()                                // сортировка коллекции
        {
            vehicleCollection.Sort();
            Console.WriteLine("Коллекция отсортированна");
        }

        static void ISwiminigMethod()                               // выполнение методов интерфейся ISwiming
        {
            Console.WriteLine("Выполнение методов всех обьектов, поддерживающих интерфейс ISwiming");
            foreach (Vehicle craft in vehicleCollection)
            {
                if (craft is ISwiming)
                {
                    ((ISwiming)craft).Swim();
                }
            }
        }

        static void Main(string[] args)
        {
            vehicleCollection = new List<Vehicle>();
            Aircraft craft1 = new Aircraft("MIG-21", 15.6);
            Amphibian craft2 = new Amphibian("Amphibian-1", 30);
            Aircraft craft3 = new Aircraft("SU-27", 23.2);
            Amphibian craft4 = new Amphibian("Amphibian-2", 33.3);
            vehicleCollection.Add(craft1);
            vehicleCollection.Add(craft2);
            vehicleCollection.Add(craft3);
            vehicleCollection.Add(craft4);
            int choice = defaultUserChoice;
            do
            {
                Console.WriteLine("**************************************");
                Console.WriteLine("*       Главное меню                 *");
                Console.WriteLine("*       выберите действие            *");
                Console.WriteLine("**************************************");
                Console.WriteLine("1 - просмотр коллекции");
                Console.WriteLine("2 - добавление элемента (конструктор с двумя параметрами)");
                Console.WriteLine("3 - добавление элемента по указанному индексу");
                Console.WriteLine("4 - нахождение элемента с начала коллекции");
                Console.WriteLine("5 - нахождение элемента с конца коллекции");
                Console.WriteLine("6 - удаление элемента по индексу");
                Console.WriteLine("7 - удаление элемента по значению");
                Console.WriteLine("8 - реверс коллекции");
                Console.WriteLine("9 - сортировка");
                Console.WriteLine("10 - выполнение методов всех обьектов, поддерживающих Interface2");
                Console.WriteLine("11 - при помощи Parallel.ForEach итерация по коллекции");
                Console.WriteLine("0 -  выход");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        ShowAll();
                        break;
                    case 2:
                        AddNewObject();
                        break;
                    case 3:
                        AddByIndex();
                        break;
                    case 4:
                        FirstElement();
                        break;
                    case 5:
                        LastElement();
                        break;
                    case 6:
                        DellByIndex();
                        break;
                    case 7:
                        DellByValue();
                        break;
                    case 8:
                        ReverseCollection();
                        break;
                    case 9:
                        SortCollection();
                        break;
                    case 10:
                        ISwiminigMethod();
                        break;
                    case 11:
                        ParallelLoopResult result = Parallel.ForEach(vehicleCollection, item =>
                        {
                            Console.WriteLine(item.name);
                        });
                        break;
                    default: return;
                }
            }
            while (choice != 0);
        }
    }
}
