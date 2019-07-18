using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1_var_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Plane plane1 = new Plane(1, 11, new int[4] {60, 90, 100, 100 }, 500, 5000, 700, 5000 );
            Plane plane2 = new Plane();
            Plane plane3 = new Plane(13); 
            plane1.print();
            plane1.CalculateConsumption();
            plane1.DamageEngine();
            Console.WriteLine();
            plane2.print();
            plane2.CalculateConsumption();
            Console.WriteLine();
            plane3.print();
            plane3.CalculateConsumption();
            plane3.DamageEngine();
            Console.WriteLine();
            if (!plane1.Faster(plane3))
            {
                Console.WriteLine("Самолет  с номером борта " + plane3.BoardNumber + " быстрее самолета  с номером борта " + plane1.BoardNumber);
            }
            else
            {
                Console.WriteLine("Самолет с номером борта " + plane1.BoardNumber + " быстрее самолета с номером борта " + plane3.BoardNumber);
            }
            Console.WriteLine();
            Console.WriteLine("Определяем самый быстрый самолет");
            Plane.BeFaster(plane1, plane2, plane3).print();
            Console.ReadKey();
        }
    }
}
