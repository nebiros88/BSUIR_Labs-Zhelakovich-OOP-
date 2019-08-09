using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5_Korbut
{
    class Car
    {
        public string name = null;
        public int maxSpeed = 0;
        public int currentSpeed = 0;
        public bool engineState = true;
        private int limitSpeed = 300;
        public int MaxSpeed
        {
            get { return maxSpeed; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("\nМаксимальная скорость не может быть отрицатеьлной!");
                }
                else if (value > limitSpeed)
                {
                    Console.WriteLine("\nПревышение допустимой масимальной скорости!");
                }
                else maxSpeed = value;
            }
        }
        public Car()
        {
            name = "TestCar";
            maxSpeed = 200;
            currentSpeed = 0;
        }
        public Car(string _name, int _maxSpeed)
        {
            this.name = _name;
            this.maxSpeed = _maxSpeed;
        }

        public delegate void CarStateHandler(string message);   // Обьявление делегата
        public event CarStateHandler DamageEngine;              // Событие возникающее при поломке двигателя

        public static bool CheckEngine(Car _car)
        {
            if (_car.maxSpeed - _car.currentSpeed > 10)  Console.WriteLine("\nАвтомобиль продолжает движение!");
            if (_car.maxSpeed - _car.currentSpeed <= 10) Console.WriteLine("\nАвтомобиль продолжает движение! Высокая скорость! ");
            if (_car.currentSpeed == _car.maxSpeed) Console.WriteLine("\nДостигнута максимальная скорость! Двигатель выйдет из строя!");
            if (_car.currentSpeed > _car.maxSpeed) _car.engineState = false;
            return _car.engineState;
        }
        public void Accelerate( int acceleration)
        {
            for ( ; engineState != false; currentSpeed += acceleration)
            {
                CheckEngine(this);
                Console.WriteLine("Автомобиль с именем {0} ускорился на {1}км/ч. Текущая скорость автомобиля составляет - {2}км/ч", name, acceleration, currentSpeed);
            }
            if (!engineState)                         // Условие для возникновения события (Событие без параметра)
            {
                if (DamageEngine != null)                       
                {
                    DamageEngine($"Двигатель поврежден!");
                }
            }
        }
    }
}
