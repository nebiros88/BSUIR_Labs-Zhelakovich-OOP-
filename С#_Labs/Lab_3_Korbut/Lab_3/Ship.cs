using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    class Ship : ISwiming
    {
        public string name;
        private int SwimingSpeed;

        public void Swim()
        {
            Console.WriteLine("Ship swim at the rate {0} km/h", SwimingSpeed);
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
                    throw new Exception("Swiming speed cant't be negative!");
                }
                SwimingSpeed = value;
            }
        }

        public void Print()
        {
            Console.WriteLine("This is a ship and its can swim.");
        }

        public void Capacity()
        {
            Console.WriteLine("Ship capacity is 3000 kilos");
        }
    }
}
