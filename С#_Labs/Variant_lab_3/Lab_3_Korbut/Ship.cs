using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3_Korbut
{
    class Ship : Swiming
    {
        private int SwimingSpeed;
        public int Speed
        {
            get
            {
                return SwimingSpeed;
            }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Speed can't be negative!");
                }
                SwimingSpeed = value;
            }
        }
        public void Swim()
        {
            Console.WriteLine("Ship can swim with rate {0} miles per hour", SwimingSpeed);
        }
    }
}
