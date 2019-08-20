using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Lab_6_Korbut_task_2
{
    class Program
    {
        static int[] myArray = new int[1000];
        static object locker = new object(); // создание обьекта для блокировки 

        static void Main(string[] args)
        {
            RandomiseArray();
            Thread thread1 = new Thread(new ThreadStart(MakeEquallyForIndex));
            Thread thread2 = new Thread(new ThreadStart(CountSumm));
            Thread thread3 = new Thread(new ThreadStart(Search_IndexOfMax));
            thread1.Start();
            thread2.Start();
            thread3.Start();
        }

        // Ранодомно заполнить массив
        static void RandomiseArray()
        {
            Random rand = new Random();
            for(int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = rand.Next(0, 999);
            }
        }
        // Для десяти случайных элементов массива восстанавливает их значения = индексу
        static void MakeEquallyForIndex()
        {
            Random rand = new Random();
            for (int i = 0; i < 10; i++)
            {
                int temp = rand.Next(0, 999);
                Console.WriteLine($"Элемент массива под индексом {temp} со значением {myArray[temp]} приравнивается к индексу элемента");
                myArray[temp] = temp;
            }
        }
        // Считает сумму элементов массива
        static void CountSumm()
        {
            lock (locker)                                       // Критическая секция
            {
                int summ = 0;
                for (int i = 0; i < myArray.Length; i++)
                {
                    summ += myArray[i];
                }
                Console.WriteLine($"Сума элементов массива равна {summ}");
            }
        }
        //  Находит индекс максимального элемента
        static void Search_IndexOfMax()
        {
            int max = 0;
            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] > max)
                {
                    max = i;
                    Console.WriteLine($"Поиск индекса максимального элемента. Сейчас максимальный элемент с индексом {max}");
                }
            }
            Console.WriteLine("Поиск индекса максимального элемента завершен.");
            Console.WriteLine($"Максимальный элемент находидтся в массиве под индексом {max}");
        }
    }
}
