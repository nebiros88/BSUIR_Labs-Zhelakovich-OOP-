
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    class Aircraft : Vehicle, IFlying
    {
        public Aircraft()               //конструктор
        {
            name = "NoName";
            weight = 0;
        }
        public Aircraft(string aircraftName, double aircraftWieght)
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
            set
            {
                if (value < 0)
                {
                    throw new Exception("Speed can't be negative!");
                }
                FlyingSpeed = value;
            }
        }
        public void Print()
        {
            Console.WriteLine("This is an aircraft with name -{0}- and it's wieght is -{1} - ton.", name, weight);
        }
        public void Capacity()
        {
            Console.WriteLine("Aircraft capacity is 1500 kilos");
        }
    }

}
