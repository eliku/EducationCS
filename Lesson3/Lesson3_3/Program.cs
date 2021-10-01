using System;

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
            string Str;
            Console.WriteLine("Введите строку.");
            Str = Console.ReadLine();
            //Создаем массив длиной равное длине строки
            char[] StrArray = new char[Str.Length];
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
        }
    }
}
