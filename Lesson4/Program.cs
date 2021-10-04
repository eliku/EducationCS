using System;
/*Домашнее задание:
 * Написать метод GetFullName(string firstName, string lastName, string patronymic), 
 * принимающий на вход ФИО в разных аргументах и возвращающий объединённую строку с ФИО.
 * Используя метод, написать программу, выводящую в консоль 3–4 разных ФИО.
 */

namespace Lesson4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetFullName(GetUserName("Введите фамилию"), GetUserName("Введите имя"), GetUserName("Введите отчество")));
            Console.WriteLine(GetFullName(GetUserName("Введите фамилию"), GetUserName("Введите имя"), GetUserName("Введите отчество")));
            Console.WriteLine(GetFullName(GetUserName("Введите фамилию"), GetUserName("Введите имя"), GetUserName("Введите отчество")));
        }
        //метод объединения в одну строку ФИО
        static string GetFullName(string firstName, string lastName, string patronymic)
        {
            return $"{firstName} {lastName} {patronymic}";        
        }
        //метод запроса информации
        static string GetUserName(string text)
        {
            Console.WriteLine(text);
            return Console.ReadLine(); 
        }

    }
}
