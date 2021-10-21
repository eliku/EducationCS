using System;
/*Домашнее задание
 *  Написать программу, вычисляющую число Фибоначчи для заданного значения рекурсивным способом. 
 */

namespace Lesson4_4
{
    class Program
    {

        public static void Main(string[] args)
        {

            Console.WriteLine("Введите число");
            Console.WriteLine($"Число Фибоначи = {Fibonachi(Convert.ToInt32(Console.ReadLine()))}");
        }

        static int Fibonachi(int n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;
            return Fibonachi(n - 1) + Fibonachi(n - 2);
        }
    }
}
