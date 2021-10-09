using System;
using System.IO;

/*
 * Ввести с клавиатуры произвольный набор данных и сохранить его в текстовый файл.
 */

namespace Lesson5
{
    class Program
    {
        static void Main(string[] args)
        {
            string filename = "text.txt";

            //Вод с клавиатуры произвольный набор данных
            Console.WriteLine("Введите произвольный набор данных");
            File.WriteAllText(filename, Console.ReadLine()); // записываем в файл строку
        }
    }
}
