using System;

/*Домашнее задание
 *Написать программу, принимающую на вход строку — набор чисел, разделенных пробелом,
 *и возвращающую число — сумму всех чисел в строке. Ввести данные с клавиатуры и вывести результат на экран. 
 */
namespace Lesson4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите числа через пробел.");
            Console.WriteLine($"Сумма чисел = {SumAllNum(Console.ReadLine())}");
        }
        //вычисление сумму всех чисел разделенных пробелом
        static int SumAllNum(string StrNum)
        {
            string[] subs = StrNum.Split(' ');
            int sum = 0;
            for (int i = 0; i < subs.Length; i++) {
                sum += Convert.ToInt32(subs[i]);
            }
            return sum;
        }
    }
}
