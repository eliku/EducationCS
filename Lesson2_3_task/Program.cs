using System;

/*
 * Домашнее задание
 * Определить, является ли введённое пользователем число чётным.
 */

namespace Lesson2_3_task
{
    class Program
    {
        static void Main(string[] args)
        {
            int UserNumber;
            //---------------Третье задание--------------------------------------
            //Запрашиваем у пользователя число
            Console.WriteLine("Введите число");
            //Присваиваем переменной
            UserNumber = Convert.ToInt32(Console.ReadLine());
            if ((UserNumber % 2) == 0) Console.WriteLine($"Введеное число {UserNumber} является четным.");
            else Console.WriteLine($"Введеное число {UserNumber} является нечетным.");
        }
    }
}
