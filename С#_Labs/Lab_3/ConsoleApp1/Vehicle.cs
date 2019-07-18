using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    public abstract class Vehicle : IComparable
    {
        public string name;
        public double weight;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }
        public Vehicle()
        {
            name = "NoName";
            weight = 0;
        }
        public Vehicle(string newName, double newWeight)
        {
            this.name = newName;
            this.weight = newWeight;
        }
        public void Print1()
        {
            Console.WriteLine("The type of vehicle is -{0}- with name -{1}- and weight -{2}- ton",
                this.ToString(), name, weight);
        }
        public int CompareTo(object a)         //описание методя для сравнения (далее применен при сортировке в коллекции)
        {
            return this.name.CompareTo(((Vehicle)a).name);
        }
    }
}
