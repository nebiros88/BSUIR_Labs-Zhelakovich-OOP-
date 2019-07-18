using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    interface IFlying
    {
        void Fly();
        int Speed { get; set; }
        void Print();           //метод для реализации склеивания
        void Capacity();        //кастинг
    }
}

