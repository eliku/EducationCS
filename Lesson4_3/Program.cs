using System;
/*Домашнее задание
 * Написать метод по определению времени года. На вход подаётся число – порядковый номер месяца. 
 * На выходе — значение из перечисления (enum) — Winter, Spring, Summer, Autumn. 
 * Написать метод, принимающий на вход значение из этого перечисления и возвращающий название времени года (зима, весна, лето, осень). 
 * Используя эти методы, ввести с клавиатуры номер месяца и вывести название времени года. 
 * Если введено некорректное число, вывести в консоль текст «Ошибка: введите число от 1 до 12».
 */

namespace Lesson4_3
{
    class Program
    {
        public enum Seasons_eng
        {
            Winter, 
            Spring, 
            Summer, 
            Autumn
        };

        public enum Seasons_rus
        {
            зима, 
            весна, 
            лето, 
            осень
        };

        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер месяца");
            Console.WriteLine(SelectSeason(Convert.ToInt32(Console.ReadLine(), true)));
        }
        public static string SelectSeason(int Month, bool language)
        {
            switch (Month) 
            {
                case 12:
                case 1:
                case 2:
                    if (language)
                    {
                        return (Seasons_eng.Winter).ToString();
                    }
                    else {
                        return (Seasons_rus.зима).ToString();
                    }
                    break;
                case 3:
                case 4:
                case 5:
                    return (Seasons_eng.Spring).ToString();
                    break;
                case 6:
                case 7:
                case 8:
                    return (Seasons_eng.Summer).ToString();
                    break;
                case 9:
                case 10:
                case 11:
                    return (Seasons_eng.Autumn).ToString();
                    break;
                default:
                    return "Ошибка: введите число от 1 до 12.";
                    break;

            }
            return "lkjnl";
        }

    }
}
