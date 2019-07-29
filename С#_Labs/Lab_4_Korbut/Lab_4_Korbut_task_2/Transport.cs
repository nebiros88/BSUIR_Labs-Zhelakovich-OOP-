using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4_Korbut_task_2
{
    abstract class Transport
    {
        public string engineType;           //тип двигателя(бензин,дизель)
        public int wheelsNumber;            //количество колес
        public int seats;                   //количество мест
        
        public int WheelsNumber
        {
            get
            {
                return wheelsNumber;
            }
            set
            {
                if (wheelsNumber < 2)
                {
                    throw new Exception("Колес не может быть меньше двух!");
                }
                wheelsNumber = value;
            }
        }

        public int Seats
        {
            get
            {
                return seats;
            }
            set
            {
                if (seats < 1  || seats < 0)
                {
                    throw new Exception("Количество мест не может быть меньше единиицы или быть отрицательным числом");
                }
                seats = value;
            }
        }

        public Transport()
        {
            this.engineType = "diesel";
        }

        public void Identify()
        {
            Console.WriteLine("Я перемещаюсь");
        }
        public virtual void Refuel()
        {
            Console.WriteLine("Я заправляюсь дизелем");
        }

        public abstract string Loading(int fuel, int electricity);

        public virtual void print()
        {
            Console.WriteLine("Обьект класса транспорт с следующими  полями ");
            Console.WriteLine("Тип двигателя -" + engineType);
            Console.WriteLine("Количестов колес -" + wheelsNumber);
            Console.WriteLine("Количество мест -" + seats);
        }
    }
}
