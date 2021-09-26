﻿using System;

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
            int TemperatureMin, TemperatureMax, MonthNumber;
            float TemperatureAve; 

            //-----------------Первое задание----------------------------------------
            //Запрашиваем у пользователя минимальную температуру за сутки
            Console.WriteLine("Введите минимальную температуру за сутки");
            //Присваиваем переменной
            TemperatureMin = Convert.ToInt32(Console.ReadLine());

            //Запрашиваем у пользователя максимальную температуру за сутки
            Console.WriteLine("Введите максимальную температуру за сутки");
            //Присваиваем переменной
            TemperatureMax = Convert.ToInt32(Console.ReadLine());

            TemperatureAve = (float)(TemperatureMin + TemperatureMax) / 2;

            Console.WriteLine($"Среднесуточная температура за сутки {TemperatureAve}.");

            //-----------------Второе задание----------------------------------------
            //Запрашиваем у пользователя порядковый номер текущего месяца
            Console.WriteLine("Введите порядковый номер текущего месяца");
            //Присваиваем переменной
            MonthNumber = Convert.ToInt32(Console.ReadLine());
            string[] Mouth = {"Январь", "Февраль", "Март", "Апрель", "Май", "Июнь", "Июль", "Август", "Сентябрь", "Октябрь", "Ноябрь", "Декабрь"};
            //Выводим название месяца
            switch (MonthNumber) {
                case  1:
                case  2:
                case  3:
                case  4:
                case  5:
                case  6:
                case  7:
                case  8:
                case  9:
                case 10:
                case 11:
                case 12:
                    Console.WriteLine($"Название введеного текущего номера {Mouth[MonthNumber-1]}.");
                    break;
                default:
                    Console.WriteLine("Не верный номер месяца.");
                    break;
            }

        }
    }
}
