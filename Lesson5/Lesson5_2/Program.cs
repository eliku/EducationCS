using System;
using System.IO;
/*Домашнее задание
 * Написать программу, которая при старте дописывает текущее время в файл «startup.txt». 
 */

namespace Lesson5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string filename = "startup.txt";
            //дописывает текущее время в файл «startup.txt»
            File.AppendAllLines(filename, new[] { DateTime.Now.ToShortTimeString().ToString() });
        }
    }
}
