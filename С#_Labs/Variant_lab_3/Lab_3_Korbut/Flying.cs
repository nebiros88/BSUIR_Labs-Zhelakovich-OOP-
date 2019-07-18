using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3_Korbut
{
    interface Flying                            //интерфейс
    {
        void Fly();                             //метод интерфейса
        void Print();
        int Speed { get; set; }                 //свойство

    }
}
