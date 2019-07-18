using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1_Agregation_
{
    class Aircraft                                  //Класс самолет
    {
        private int boardNumber;
        private int landingValue;                   //Требуемая длина ВВП
        private Airport nameAirport;                //Агрегация по отношению к ВВП

        public int Boardnumber
        {
            get
            {
                return boardNumber;
            }
            set
            {
                if (value < 0)
                {
                    throw new Exception("The boardnumber can't be a negative value!");
                }
                boardNumber = value;
            }
        }
        public int LandingValue
        {
            get
            {
                return landingValue;
            }
            set
            {
                if (value < 0)
                {
                    throw new Exception("The landing value can't be a negative value!");
                }
                landingValue = value;
            }
        }

        public Aircraft()
        {
            boardNumber = 0;
            landingValue = 0;
            nameAirport = null;
        }

        public Aircraft(int a, int b, Airport c)
        {
            this.boardNumber = a;
            this.landingValue = b;
            this.nameAirport = c;
        }

        public void print()
        {
            Console.WriteLine();
            Console.WriteLine("Летит самолет с номером борта " + boardNumber + " и требуемой длинной ВВП в " + landingValue + " километра");
            Console.WriteLine("Самолет направляется в аэропорт с именем " + nameAirport.name);
        }

        public  void ChooseRunway(Airport name, Aircraft craft)
        {
            bool result = false;
            for (int i = 0; i < name.runways.Length; i++)     
            {
                if (name.runways[i].IsLength(craft))
                {
                    result = true;
                    Console.WriteLine("Самолет сядет на полосу номер " + name.runways[i].Number);

                }

            }
            if (!result)
            {
                Console.WriteLine("В посадке отказано!");
            }
        }
    }
}
