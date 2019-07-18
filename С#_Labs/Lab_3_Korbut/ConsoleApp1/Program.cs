using Lab_3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleApp1
{
    class Program
    {
        static void ShowList(ArrayList nameList)                //просмотр коллекции
        {
            Console.WriteLine("---------------------------------------------------------------------");
            foreach (Vehicle craft in nameList)
            {
                craft.Print1();
            }
            Console.WriteLine("---------------------------------------------------------------------");
        }

        static void AddObject(ArrayList nameList)               //добавление элемента (конструктор с двумя параметрами)
        {
            Console.WriteLine("Введите имя обьекта...");
            string objectName = Console.ReadLine();
            Console.WriteLine("Введите массу обьекта...");
            double objectWeieght = double.Parse(Console.ReadLine());
            Console.WriteLine("Выберите тип создаваемого обьекта...");
            Console.WriteLine("*1 - самолет                       *");
            Console.WriteLine("*2 - самолет-амфибия               *");
            int choice1 = int.Parse(Console.ReadLine());
            if (choice1 == 1)
            {
                Aircraft userObject = new Aircraft(objectName, objectWeieght);
                nameList.Add(userObject);
                Console.WriteLine("Самолет с именем -{0}- и массой -{1}- тонн ------- успешно добавлен в коллецию", objectName, objectWeieght);
            }
            else if (choice1 == 2)
            {
                Amphibian userObject = new Amphibian(objectName, objectWeieght);
                nameList.Add(userObject);
                Console.WriteLine("Самолет-амфибия с именем -{0}- и массой -{1}- тонн ------- успешно добавлен в коллецию", objectName, objectWeieght);
            }
            else Console.WriteLine("Выбран не верный тип создаваемого обьекта");
        }

        static void AddByIndex(ArrayList nameList)              //добавление элемента по указанному индексу
        {
            Console.WriteLine("Введите имя обьекта...");
            string objectName = Console.ReadLine();
            Console.WriteLine("Введите массу обьекта...");
            double objectWeieght = double.Parse(Console.ReadLine());
            Console.WriteLine("Выберите тип создаваемого обьекта...");
            Console.WriteLine("*1 - самолет                       *");
            Console.WriteLine("*2 - самолет-амфибия               *");
            int choice1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите индекс добавляемого элемента...");
            int objectIndex = int.Parse(Console.ReadLine());    //запрос на ввод индекса добавляемого обьекта
            if (choice1 == 1)
            {
                Aircraft userObject = new Aircraft(objectName, objectWeieght);
                nameList.Insert(objectIndex, userObject);
                Console.WriteLine("Самолет с именем -{0}- и массой -{1}- тонн ------- успешно добавлен в коллецию", objectName, objectWeieght);
            }
            else if (choice1 == 2)
            {
                Amphibian userObject = new Amphibian(objectName, objectWeieght);
                nameList.Insert(objectIndex, userObject);
                Console.WriteLine("Самолет-амфибия с именем -{0}- и массой -{1}- тонн ------- успешно добавлен в коллецию", objectName, objectWeieght);
            }
            else Console.WriteLine("Выбран не верный тип создаваемого обьекта");
        }


        static void Main(string[] args)
        {
           Vehicle[] crafts = new Vehicle[5] {new Aircraft("SU-27", 16.9), new Aircraft("MIG-29", 10.9 ),
           new Amphibian("DINGO", 3.6), new Amphibian("BE-200", 27.6), new Aircraft("SU-35", 19.0 )};
            ArrayList arrayList = new ArrayList();
            arrayList.AddRange(crafts);
            int choice = 11;
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
                Console.WriteLine("0 -  выход");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        ShowList(arrayList);
                        break;
                    case 2:
                        AddObject(arrayList);
                        break;
                    case 3:
                        AddByIndex(arrayList);
                        break;
                    case 4:
                        Console.WriteLine("Элемент с начала коллекци");
                        ((Vehicle)arrayList[0]).Print1();
                        break;
                    case 5:
                        Console.WriteLine("Элемент с конца коллекци");
                        ((Vehicle)arrayList[(arrayList.Count) - 1]).Print1();
                        break;
                    case 6:
                        Console.WriteLine("Ввдите индекс удаляемого обьекта");
                        int delIndex = int.Parse(Console.ReadLine());
                        if (delIndex < 0 || delIndex >= (arrayList.Count))
                        {
                            Console.WriteLine("Неверный индекс!");
                        }
                        else
                        {
                            arrayList.RemoveAt(delIndex);
                            Console.WriteLine("Элемент с индексом {0} успешно удален из коллекции", delIndex);
                        }
                        break;
                    case 7:
                        Console.WriteLine("*********Удаление элемента по значению*************");
                        Console.WriteLine("Введите имя удаляемого обьекта...");
                        string delObjectname = Console.ReadLine();
                        int craftIndex = 0;
                        int craftIndex1 = 0;
                        bool condition = false;
                        foreach (Vehicle craft in arrayList )
                        {
                            if (delObjectname == craft.name)
                            {
                                craftIndex1 = craftIndex;
                                condition = true;
                            }
                            craftIndex++;
                        }
                        if (condition)
                        {
                            Console.WriteLine("Элемент с указанным значением существует в коллекции и будет удален");
                            arrayList.RemoveAt(craftIndex1);
                        }
                        else Console.WriteLine("Элемент с указанным значением не найден!");
                        break;
                    case 8:
                        Console.WriteLine("Реверс коллекции выполнен");
                        arrayList.Reverse();
                        break;
                    case 9:
                        Console.WriteLine("Сортировка коллекции выполнена");
                        arrayList.Sort();
                        break;
                    case 10:
                        Console.WriteLine("Выполнение методов всех обьектов, поддерживающих интерфейс ISwiming");
                        foreach (Vehicle craft in arrayList) 
                        {
                            if (craft is ISwiming )
                            {
                                ((ISwiming)craft).Swim();
                            }
                        }
                        break;
                    default: return;
                }
            } while (choice != 0);

        }
    }
}
