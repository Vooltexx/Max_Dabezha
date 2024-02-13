using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0009999
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Выполнить инициализацию одномерного массива с использованием конструктора без указания значений элементов, заполнить массив с клавиатуры и вывести на экран.
            //int[] omas = new int[6];
            //for (int i = 0; i < 6; i++)
            //{
            // Console.Write($"omas[{i}]=");
            // omas[i] = int.Parse(Console.ReadLine());
            //}
            //for (int i = 0; i < 6; i++)
            //{
            // Console.WriteLine($"omas[{i}]={omas[i]}");
            //}

            //int i;
            //int[] omas = new int[6];
            //for (i = 0; i < omas.Length; i++)
            //{
            // Console.Write($"omas[{i}]=");
            // omas[i] = int.Parse(Console.ReadLine());
            //}
            //for (i = 0; i < omas.Length; i++)
            //{
            // Console.WriteLine($"omas[{i}]={omas[i]}");
            //}   

            //2.Инициализировать одномерный массив с использованием конструктора, без указания размерности массива и без клавиатуры.
            //int i;
            //int[] omas = { -3, 5, 7, -1, 10, 15 };
            //for (i = 0; i < omas.Length; i++)
            //{
            // Console.Write($"omas[{i}]={omas[i]}");
            //}


            //3.Заполнить одномерный массив соответствующими индексами(по формуле) и вывести с использованием цикла foreach.
            //int i;
            //int[] omas = new int[6];
            //for (i = 0; i < 6; i++)
            //{
            //    omas[i] = i * i - 1;


            //}
            //foreach (int elem in omas) Console.WriteLine(elem);
            //4.Заполнить одномерный массив случайным образом и вывести на экран с использованием цикла foreach.
            Random r = new Random(); 
            int[] omas = new int[6]; 
            for (int i = 0; i < 6; i++)
            {
                omas[i] = r.Next(1, 101);
            }
            foreach (int elem in omas)
            {
                Console.WriteLine(elem);
            }
            Console.ReadKey();
        }
    }
}
