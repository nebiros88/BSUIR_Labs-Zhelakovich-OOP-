using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3_Korbut
{
    class Hydroplane : Aircraft, Swiming
    {
        new public int FlyingSpeed;
        public int SwimingSpeed;
        public override void Fly()              //переопределение метода производного класса
        {
            Console.WriteLine("Hydroplane fly with rate {0} miles per hour", FlyingSpeed);
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
                    throw new Exception("Speed can't be negative!");
                }
                FlyingSpeed = value;
            }
        }
        public void Swim()
        {
            Console.WriteLine("Hydroplane swim with rate {0} miles per hour", SwimingSpeed);
        }

        public new void Print()             
        {
            Console.WriteLine("This is a hydroplane and its' abilities is flying and swimming");
        }



    }
}
