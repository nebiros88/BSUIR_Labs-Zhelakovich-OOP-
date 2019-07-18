using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_var3_task2
{
    class Interval
    {
        private double begin;
        private double end;

        public double Begin
        {
            get
            {
                return begin;    
            }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Начало интервала не может быть меньше 0!");
                }
                else
                {
                    begin = value;
                }
            }
        }

        public double End
        {
            get
            {
                return end;
            }
            set
            {
                if (value < 0 || value < begin)
                {
                    Console.WriteLine("Конец интервала не может быть меньше 0 или меньше начала интервала");
                    end = begin + 1;
                }
                else
                {
                    end = value;
                }
            }
        }

        public Interval(double begin, double end)       //Конструктор объекта
        {
            Begin = begin;
            End = end;
        }

        public double GetLenght()                      //Метод вычисления длины интервала
        {
            double result = end - begin;
            return result;
        }

        public override string ToString()
        {
            return String.Format("Begin = {0} End = {1}", Begin, End);
        }

        public static Interval operator+(Interval interval, int value)        //Перегрузка +
        {
            return new Interval(interval.begin, interval.end + value);
        }

        public static Interval operator -(Interval interval, int value)       //Перегрузка -
        {
            //return new Interval(lValue.begin, lValue.end + (-value));
            return interval + (-value);
        }

        public static Interval operator ++(Interval value)                  //Инкремент перегрузка
        {
            //return new Interval(lValue.begin, lValue.end + 1);
            return value + 1;
        }

        public static Interval operator --(Interval value)                  //Декремент перегрузка
        {
            return value - 1;
        }

        public static Interval operator *(Interval interval1, int value)    //Перегрузка умножения
        {
            return new Interval(interval1.begin, interval1.end * value);
        }

        public static bool operator !=(Interval int1, Interval int2)
        {
            if (int1.GetLenght() != int2.GetLenght()) 
                return true;
            return false;
        }

        public static bool operator ==(Interval int1, Interval int2)
        {
            if (int1.GetLenght() == int2.GetLenght())
                return true;
            return false;
        }

        public static implicit operator Interval (double a)
        {
            return new Interval(0,  a);
        }

        public static explicit operator double (Interval name1)
        {
            return (name1.End - name1.Begin);
        }

        public double this[int i]
        {
            get
            {
                if (i == 0)
                {
                    return Begin;
                }
                if (i == 1)
                {
                    return End;
                }
                return -1;
            }
            set
            {
                if (i == 0)
                {
                    begin = value;
                }
                if (i == 1)
                {
                    end = value;
                }
            }
        }

        public static bool operator true(Interval name)
        {
            if (name.GetLenght() > 0)
            {
                return true;
            }
            return false;

        }

        public static bool operator false(Interval name)
        {
            if (name.GetLenght() <= 0)
            {
                return false;
            }
            return true;
        }






    }
}
