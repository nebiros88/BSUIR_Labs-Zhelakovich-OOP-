using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1_Agregation_
{
    class Program
    {

        static void Main(string[] args)
        {
            Airport n1 = new Airport("Минск-2", 3);
            n1.print();
            Aircraft craft1 = new Aircraft(1, 3, n1);
            craft1.print();
            craft1.ChooseRunway(n1, craft1);
            LandingRequest(n1, craft1);  
            Aircraft craft2 = new Aircraft(2, 1, n1);
            craft2.print();
            craft2.ChooseRunway(n1, craft2);
            LandingRequest(n1, craft2);
            Aircraft craft3 = new Aircraft(3, 2, n1);
            craft3.print();
            craft3.ChooseRunway(n1, craft3);
            LandingRequest(n1, craft3);
            Aircraft craft5 = new Aircraft(5,1,n1);
            craft5.print();
            craft5.ChooseRunway(n1, craft5);
            LandingRequest(n1, craft5);
            Console.WriteLine();
            Airport n2 = new Airport("Минск", 1);
            n2.print();
            Aircraft craft4 = new Aircraft(4, 6, n2);
            craft4.print();
            craft4.ChooseRunway(n2, craft4);
        }
        static void LandingRequest(Airport airport, Aircraft aircraft)
        {
            if (airport.LandingCraft(aircraft))
            {
                Console.WriteLine("Самолет успешно приземлился");
            }
            else
            {
                Console.WriteLine("В посадке отказано! Недостаточно мест в аэропорту!");
            }
        }
    }
}

