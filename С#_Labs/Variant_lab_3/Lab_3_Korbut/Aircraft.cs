using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3_Korbut
{
    class Aircraft : Flying
    {
        private int FlyingSpeed;
        public virtual void Fly()           //метод интерфейса определен как виртуальный
        {
            Console.WriteLine("Aircraft fly with rate {0} miles per hour", FlyingSpeed);
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
        public void Print()                //для дальнейшего сокрытия метода в производном классе
        {
            Console.WriteLine("This is an aircraft and it's can fly");
        }
    }
}
