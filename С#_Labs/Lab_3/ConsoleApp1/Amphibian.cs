using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    class Amphibian : Aircraft, ISwiming        //класс от самолета + наследование интерфейса корабля

    {
        public Amphibian()
        {
            name = "NoName";
            weight = 0;
        }
        public Amphibian(string amphibianName, double amphibianWeight)
        {
            this.name = amphibianName;
            this.weight = amphibianWeight;
        }
        public int SwimingSpeed;
        public int FlyingSpeed;
        public void Swim()
        {
            Console.WriteLine("Amphibian with name {0} can fly with rate {1} km/h and can swim {2} km/s", name, FlyingSpeed, SwimingSpeed);
        }
        public int SpeedSwim
        {
            get
            {
                return SwimingSpeed; 
            }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Swiming speed can't be negative!");
                }
                SwimingSpeed = value;
            }
        }
        public int Speed
        {
            get
            {
                return FlyingSpeed;
            }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Flying speed can't be negative!");
                }
                FlyingSpeed = value;
            }
        }
        public void Print()
        {
            Console.WriteLine("This is an amphibian with name -{0}- and it's wieght is -{1} - ton.", name, weight);
        }
    }
}
