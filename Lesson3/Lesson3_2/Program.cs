using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Домашнее задание
 * Написать программу «Телефонный справочник»:
 * создать двумерный массив 5х2, хранящий список телефонных контактов:
 * первый элемент хранит имя контакта, второй — номер телефона/email.
 */
namespace Lesson3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //создали массив Телефонный справочник
            string[,] TelephoneDirectory = new string[5,2];
            //заполнение телефонного спавочника
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Введите данные для {i + 1} телефонного контака: \nИмя ");
                TelephoneDirectory[i,0] = Console.ReadLine();
                Console.WriteLine("номер телефона/email");
                TelephoneDirectory[i, 1] = Console.ReadLine();
            }
            Console.WriteLine("**********************************");
            Console.WriteLine("******Телефонный справочник*******");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"|  {TelephoneDirectory[i, 0]}|  {TelephoneDirectory[i, 1]}  |");
            }
            Console.WriteLine("**********************************");
            Console.ReadLine();
        }
    }
}
