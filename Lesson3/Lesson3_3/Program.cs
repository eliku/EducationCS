using System;
using System.Linq;

/*Домашнее задание 
 * Написать программу, 
 * выводящую введенную пользователем строку в обратном порядке (olleH вместо Hello).
 */
namespace Lesson3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку.");
            string  Str = Console.ReadLine();
            //Создаем массив длиной равное длине строки
            char[] StrArray = new char[Str.Length];
            //Первый способ
            Console.WriteLine("Первый способ");
            //Переворачиваем строку и записываем в созданный массив
            for (int i = Str.Length - 1; i >=0; i--) 
            {
                StrArray[Str.Length - 1 - i] = Str[i];
            }
            //выводим строку наоборот
            for (int i =0; i < Str.Length; i++)
            {
                Console.Write($"{StrArray[i]}");
            }
            //Второй способ
            Console.WriteLine();
            Console.WriteLine("Второй способ");
            Console.WriteLine(new string(Str.Reverse().ToArray()));
        }
    }
}
