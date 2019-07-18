using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{ 
    class Program
    {
        static void Main(string[] args)
        {
            Aircraft Mig = new Aircraft();  // обьект класса самолет с интерфейсом полета (IFly)
            Mig.Speed = 1000;
            Mig.Fly();
            Mig.Print();
            Console.WriteLine();

            Ship Liner = new Ship();
            Liner.SpeedSwim = 30;
            Liner.Swim();
            Liner.Print();
            Console.WriteLine();

            Amphibian An = new Amphibian(); //обьект класса самолет с интерфейсом плавания (ISwim) и родительского класса смолет с (IFly)
            An.Speed = 500;
            An.SpeedSwim = 90;
            An.Swim();
            An.Print();                     //коллизия имен - решение через склеивание
            Console.WriteLine();
            ((ISwiming)An).Capacity();      //коллизия имен - решение через кастинг
            ((IFlying)An).Capacity();       //кастинг
            Console.WriteLine();
            An.SwimingCapacity();           //кастинг + обертывание (Переименование)
            Console.WriteLine();
            IFlying[] objectsArray = new IFlying[4] { new Aircraft("aircraft1", 10), new Amphibian("amphibian1"), new Aircraft("aircraft2", 11), new Amphibian("amphibian2")}; //создание массива типа Iterface1 (IFlying)
            foreach (IFlying flying in objectsArray) //вызов метода Swim из Interface2  для всех элементов массива котороые его поддерживают
            {
                if (flying is ISwiming)
                {
                    ((ISwiming)flying).Swim();
                }
            }
            Console.WriteLine();
            Console.WriteLine("*************************");
            Console.WriteLine("*   Before sort         *");
            Console.WriteLine("*************************");
            foreach (IFlying flying in objectsArray)
            {
                ((Aircraft)flying).Print();
            }
            Array.Sort(objectsArray);                       //сортировка массива
            Console.WriteLine("*************************");
            Console.WriteLine("*   After sort          *");
            Console.WriteLine("*************************");
            foreach (IFlying flying in objectsArray)
            {
                ((Aircraft)flying).Print();
            }
            Console.WriteLine();
            Aircraft[] planes = new Aircraft[5] {new Aircraft("mig-25", 15), new Aircraft("mig-21", 12),
            new Aircraft("su-27", 19), new Aircraft("su-24", 18), new Aircraft("F-35", 25)};
            Console.WriteLine("*************************");
            Console.WriteLine("*   Before sort         *");
            Console.WriteLine("*************************");
            foreach (Aircraft model in planes)
            {
                model.Print1();
            }
            Array.Sort(planes, new CompAircraftName());         //сортировка массива по имени
            Console.WriteLine("*************************");
            Console.WriteLine("*   After sort by name  *");
            Console.WriteLine("*************************");
            foreach(Aircraft model in planes)
            {
                model.Print1();
            }
            Array.Sort(planes, new CompareAircraftWeight());    //сортировка массива по весу
            Console.WriteLine("*************************");
            Console.WriteLine("* After sort by weight  *");
            Console.WriteLine("*************************");
            foreach(Aircraft model in planes)
            {
                model.Print1();
            }

        }
    }
}
