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
            Console.WriteLine(SelectSeason(Convert.ToInt32(Console.ReadLine()), true));
            Console.WriteLine("Введите номер месяца");
            Console.WriteLine(SelectSeason(Convert.ToInt32(Console.ReadLine()), false));
        }
         static string SelectSeason(int Month, bool language)
        {
            switch (Month) 
            {
                case 12:
                case 1:
                case 2:
                    if (language) return (Seasons_eng.Winter).ToString();
                    else          return (Seasons_rus.зима).ToString();

                case 3:
                case 4:
                case 5:
                    if (language) return (Seasons_eng.Spring).ToString();
                    else          return (Seasons_rus.весна).ToString();
                case 6:
                case 7:
                case 8:
                    if (language) return (Seasons_eng.Summer).ToString();
                    else          return (Seasons_rus.лето).ToString();
                case 9:
                case 10:
                case 11:
                    if (language) return (Seasons_eng.Autumn).ToString();
                    else          return (Seasons_rus.осень).ToString();
                default:
                    return "Ошибка: введите число от 1 до 12.";
            }
        }

    }
}
