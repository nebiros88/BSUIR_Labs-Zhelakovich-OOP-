using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1_var_3
{
    class Plane
    {
        private int boardNumber;             //ноиер борта
        private int flightNumber;            //номер рейса
        private int[] enginePower;           //мощность двигателей (массив в процентах)
        private double consumption;          //потреблеие горючего при 100% мощности 1 двигателя за 1 час
        private int fuelVolume;              //общий обьем горючего
        private int speed;                   //скорость
        private int height;                   //высота

        public int BoardNumber
        {
            get
            {
                return boardNumber;
            }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Номер борта не может быть отрицательным!");
                }
                else
                {
                    boardNumber = value;
                }
            }
        }

        public int FlightNumber
        {
            get
            {
                return flightNumber;
            }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Номер рейса не может быть отрицательным!");
                }
                else
                {
                    flightNumber= value;
                }
            }
        }

        public int FuelVolume
        {
            get
            {
                return fuelVolume;
            }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Общий обьем горючего не может быть отрицательным!");
                }
                else
                {
                    fuelVolume = value;
                }
            }
        }

        public double Consumption
        {
            get
            {
                return consumption;
            }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Расход не может быть отрицательным!");
                }
                else
                {
                    consumption = value;
                }
            }
        }

        public int Speed
        {
            get
            {
                return speed;
            }
            set
            {
                if (value <= 0 | value > 1000)
                {

                }
                else
                {
                    speed = value;
                }
            }
        }

        public int Height
        {
            get
            {
                return height;
            }
            set
            {
                if (value <= 0 | value > 10000)
                {
                    Console.WriteLine("Ошибка при указании высоты!");
                }
                else
                {
                    height = value;
                }
            }
        }

        public void print()
        {
            Console.WriteLine("Вылетел самолоет с номером борта " + boardNumber + " , номером рейса "
                + flightNumber + ". Мощность двигателей (массив в процентах) " + enginePower[0] + " " + enginePower[1] + " " + enginePower[2] + " " + enginePower[3]);
            Console.WriteLine ("Потребеление горючего при 100% мошности 1 двигателя в час " + consumption
                + ". Общий обьем горючего " + fuelVolume + "л. Скорость " + speed
                + "км/ч. Высота " + height + " (метры)");
        }

        public void CalculateConsumption()            // Метод определяющий потребление гррючего в данном режиме полета всеми двигателями
        {
            double totalConsumption = 0;
            foreach (int power in enginePower)
            {
                totalConsumption += consumption / 100 * power; 
            }
            Console.WriteLine("Потребление горючего в данном режиме полета " + totalConsumption + " литры/час");
        }

        public void DamageEngine()                    // Метод определяющий сбой двигателя (если мощность ниже 50%, скорость и высота падают пропорционально мощности)
        {
            int totalPower = 0;
            int numberofEngines = 0;
            foreach (int power in enginePower)
            {
                totalPower += power;
                numberofEngines++;
            }
            totalPower /= numberofEngines;
            if (totalPower < 50)
            {
                Console.WriteLine("Мощность двигателей вашего самолета меньше 50% и составляет " + totalPower + "%. Ваш самолет скоро упадет(");
            }
            else
            {
                Console.WriteLine("Ваш самолет продолжает лететь с общей мощностью двигателей " + totalPower + " %");
            }
        }

        public bool Faster(Plane boardNumber)           //опреденление более быстрого самолета из двух(возвращает true если скорость текушего выше)
        {
            if (speed > boardNumber.speed)
            {
                return true;
            }
            return false;
        }

        public static Plane BeFaster(Plane name1, Plane name2, Plane name3)            // статический метод определения быстрейшего обьекта
        {
            Plane result = name1;
            if (result.speed < name2.speed)
            {
                result = name2;
            }
            if (result.speed < name3.speed)
            {
                result = name3;
            }

            return result;
        }

        public Plane()
        {
            boardNumber = 0;
            flightNumber = 0;
            enginePower = new int[4];
            consumption = 0;
            fuelVolume = 0;
            speed = 0;
            height = 0;
        }

        public Plane(int boardNumber)
        {
            this.BoardNumber = boardNumber;
            enginePower = new int[4];
        }
        public Plane(int boardNumber, int flightNumber, int[] enginePower, int consumption, int fuelVolume, int speed, int height)
        {
            this.BoardNumber = boardNumber;
            this.FlightNumber = flightNumber;
            this.enginePower = enginePower;
            this.Consumption = consumption;
            this.FuelVolume = fuelVolume;
            this.Speed = speed;
            this.Height = height;
        }

    }
}
