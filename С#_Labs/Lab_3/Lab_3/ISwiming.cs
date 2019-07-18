using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    interface ISwiming
    {
        void Swim();
        int SpeedSwim { get; set; }
        void Print();
        void Capacity();
    }
}
