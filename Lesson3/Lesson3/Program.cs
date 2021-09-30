using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Домашнее задание
 * Написать программу, выводящую элементы двумерного массива по диагонали.
 */
namespace Lesson3
{
    class Program
    {
        static void Main(string[] args)
        {
            //блок переменных
            int SizeArray;
            int Cnt;

            Console.WriteLine("Введите размерность массива");
            SizeArray =Convert.ToInt32(Console.ReadLine());
            int[,] Diagonal_Array = new int[SizeArray , SizeArray];
            Console.WriteLine("Введите двухмерный массив");
            for (int i = 0; i < SizeArray; i++)
            {
                for (int j = 0; j < SizeArray; j++)
                {
                    Console.WriteLine($"Введите элемент маассива [{i},{j}]");
                    Diagonal_Array[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            //вывод массива по диагонали
            Cnt = 0;
            for (int i = 0; i < SizeArray; i++)
            {
                for (int j = 0; j < SizeArray; j++)
                {
                    Console.WriteLine($"{new string(' ', Cnt)} {Diagonal_Array[i, j]}");
                    Cnt++;
                }
            }
            Console.ReadLine();
        }
    }
}
