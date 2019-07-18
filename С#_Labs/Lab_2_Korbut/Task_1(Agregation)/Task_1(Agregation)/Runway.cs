using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1_Agregation_
{
    class Runway                                    //Класс взлетно-посадочная полоса
    {
        private int number;
        private int runwayLenght;                   //Длина взлетно-посадочной полосы

        public int Number
        {
            get { return number; }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Runway number can't be a negative value");
                }

                number = value;
            }
        }

        public int RunwayLenght
        {
            get { return runwayLenght; }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Runway lenght can't be a negative value");
                }

                runwayLenght = value;
            }
        }

        public Runway()
        {
            number = 0;
            runwayLenght = 0;
        }

        public Runway(int a, int b)
        {
            this.number = a;
            this.runwayLenght = b;
        }

        public bool IsLength(Aircraft craft)
        {
            return craft.LandingValue == runwayLenght;
        }
    }


  

}
