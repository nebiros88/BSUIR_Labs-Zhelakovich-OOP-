using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Transport [] collection = { new Car(), new Aircraft(), new Ship(0,100,1000), new Submarine(0,0,500) };
            foreach (Transport s in collection)
            {
                Console.Write(s.GetType() + " ");
                Console.WriteLine(s.Loading(2,0));
            }
            Console.WriteLine();
            foreach (Transport s in collection)
            {
                s.print();
                Console.WriteLine();
            }
        }
    }
}
