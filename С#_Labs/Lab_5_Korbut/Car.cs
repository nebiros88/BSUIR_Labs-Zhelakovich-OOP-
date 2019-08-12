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
        public List<int> SpeedValues = new List<int>();
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

        public delegate void CarStateHandler(string message);   // Обьявление делегата (для события без параметра)
        public delegate void LimitTrafficSpeed(int n);          // -//- (для события с параметром)
        public delegate int SpeedHandler(List<int> nameList);
        public event CarStateHandler DamageEngine;              // Событие возникающее при поломке двигателя
        public event LimitTrafficSpeed Warn;                    // Событие предупреждающее о достижении ограничения скорости
        public event SpeedHandler AverageSpeed;

        private bool CheckEngine()
        {
            if (maxSpeed - currentSpeed > 10)  Console.WriteLine("\nАвтомобиль продолжает движение!");
            if (maxSpeed - currentSpeed <= 10) Console.WriteLine("\nАвтомобиль продолжает движение! Высокая скорость! ");
            if (currentSpeed == maxSpeed) Console.WriteLine("\nДостигнута максимальная скорость! Двигатель выйдет из строя!");
            if (currentSpeed > maxSpeed) engineState = false;
            return engineState;
        }
        public void Accelerate( int acceleration)
        {
            for ( ; engineState != false; currentSpeed += acceleration)
            {
                CheckEngine();
                Console.WriteLine("Автомобиль с именем {0} ускорился на {1}км/ч. Текущая скорость автомобиля составляет - {2}км/ч", name, acceleration, currentSpeed);
            }
            if (!engineState)                         // Условие для возникновения события (Событие без параметра)
            {
                if (DamageEngine != null)                       
                {
                    DamageEngine("Двигатель поврежден!");
                }
            }
        }
        public void AccelerateForMax(int n)
        {
            for (currentSpeed = 10; currentSpeed <= maxSpeed; currentSpeed += 10)
            {
                Console.WriteLine($"Машина с именем -{name} - ускорилась до {currentSpeed} км/ч.");
                SpeedValues.Add(currentSpeed);
                if (currentSpeed == n)                  // Условие для возникновения события с параметром
                {
                    Warn?.Invoke(currentSpeed);
                }
                if (currentSpeed == maxSpeed)
                {
                    AverageSpeed?.Invoke(SpeedValues);
                }
            }
        }
        public void ShowMessage(int n)
        {
            Console.WriteLine($"Вы превысили ограниечение скорости для данного участка (ограничение - {n} км/ч).");
        }
    }
}
