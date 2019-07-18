using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    class Aircraft : IFlying, IComparable
    {
        public string name;
        public int weight;
        public int Weight
        {
            get { return weight; }
            set {
                if (value < 0)
                {
                    throw new Exception("Weight can' be negative!");
                }
                weight = value;
            }
        }
        public Aircraft()               //конструктор
        {
            name = "NoName";
            weight = 0;
        }
        public Aircraft(string aircraftName, int aircraftWieght)
        {
            this.name = aircraftName;
            this.weight = aircraftWieght;
        }
        private int FlyingSpeed;
        public void Fly()
        {
            Console.WriteLine("Aircraft fly at the rate {0} km/h", FlyingSpeed);
        }
        public int Speed
        {
            get { return FlyingSpeed; }
            set {
                if (value < 0)
                {
                    throw new Exception("Speed can't be negative!");
                }
                FlyingSpeed = value;
            }
        }
        public void Print()
        {
            Console.WriteLine("This is an aircraft -{0}- and it's can fly.", name);
        }
        public void Capacity()
        {
            Console.WriteLine("Aircraft capacity is 1500 kilos");
        }
        public int CompareTo(object b1)         //описание методя для сравнения
        {
            return this.name.CompareTo(((Aircraft)b1).name);
        }
        public void Print1()
        {
            Console.WriteLine("This is an aircraft with name - {0} and with weigt - {1} ton", name, weight);
        }
    }

    class CompAircraftName : IComparer<Aircraft>    //создаем класс-компаратор для сравнения по имени обьекта
    {
        public int Compare(Aircraft a1, Aircraft a2)
        {
            return a1.name.CompareTo(a2.name);
        }
    }

    class CompareAircraftWeight : IComparer<Aircraft> //класс компаратор для сравнения по весу
    {
        public int Compare(Aircraft a1, Aircraft a2)
        {
            return a1.weight.CompareTo(a2.weight);
        }
    }

}
