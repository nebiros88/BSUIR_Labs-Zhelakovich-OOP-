using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1_Agregation_
{
    class Airport                           //Класс аэропорт
    {
        public string name;
        public Runway[] runways;            //Композиция
        public Aircraft[] aircrafts;
        public Airport()                    //Конструктор без параметров
        {
            name = "Airport 0";
            runways = new Runway[5]
            {
                new Runway(0, 0),
                new Runway(1, 0),
                new Runway(2, 0),
                new Runway(3, 0),
                new Runway(4, 0)
            };
            aircrafts = new Aircraft[3];

        }

        public Airport(string name, int runwaysNumber)   
            : this()
        {
            this.name = name;
            this.runways = new Runway[runwaysNumber];
            for (int i = 0; i < runways.Length; ++i)
            {
                this.runways[i] = new Runway(i + 1, i + 1);
            }
            
        }

        public void print()
        {
            Console.WriteLine("Аэропорт " + name + " и у него есть " + runways.Length + " полос");
            for (int i = 0; i < runways.Length; i++)
                {
                    Console.WriteLine("Полоса номер - " + runways[i].Number + " длинною " + runways[i].RunwayLenght + " километров");
                }
            Console.WriteLine();
        }

        public bool LandingCraft (Aircraft craft)       
        {
            for (int i = 0; i < aircrafts.Length; i++)
            {
                if (aircrafts[i] == null)
                {
                    aircrafts[i] = craft;
                    return true;
                }
            }
            return false;
        }



      
          




    
    }
}
