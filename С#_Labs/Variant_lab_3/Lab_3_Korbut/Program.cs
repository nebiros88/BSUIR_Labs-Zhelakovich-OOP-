using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3_Korbut
{
    class Program
    {
        static void Main(string[] args)
        {
            Aircraft boeing = new Aircraft();
            boeing.Speed = 500;
            boeing.Fly();
            boeing.Print();
            Console.WriteLine();

            Hydroplane an = new Hydroplane();
            an.Speed = 300;
            an.SwimingSpeed = 20;
            an.Fly();
            an.Swim();
            an.Print();
            Console.WriteLine();

            Ship yaht = new Ship();
            yaht.Speed = 10;
            yaht.Swim();
        }
    }
}
