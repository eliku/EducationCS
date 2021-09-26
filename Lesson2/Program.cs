using System;

/*
 * Запросить у пользователя минимальную и максимальную температуру за сутки и вывести среднесуточную температуру.
 * Запросить у пользователя порядковый номер текущего месяца и вывести его название.
 * Определить, является ли введённое пользователем число чётным.
 * 
 */
namespace Lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Блок переменных глобальных
            int TemperatureMin, TemperatureMax;
            float TemperatureAve; 


            //Запрашиваем у пользователя минимальную температуру за сутки
            Console.WriteLine("Введите минимальную температуру за сутки");
            //Присваиваем переменной
            TemperatureMin = Convert.ToInt32(Console.ReadLine());

            //Запрашиваем у пользователя максимальную температуру за сутки
            Console.WriteLine("Введите максимальную температуру за сутки");
            //Присваиваем переменной
            TemperatureMax = Convert.ToInt32(Console.ReadLine());

            TemperatureAve = (float)(TemperatureMin + TemperatureMax) / 2;

            Console.WriteLine($"Среднесуточная температура за сутки {TemperatureAve}."); ;

        }
    }
}
