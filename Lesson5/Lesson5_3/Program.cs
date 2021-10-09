using System;
using System.IO;

/* Домашнее задание
 * Ввести с клавиатуры произвольный набор чисел (0...255) и записать их в бинарный файл.
 */

namespace Lesson5_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ввести с клавиатуры произвольный набор чисел (0...255)");
            string[] Str =Console.ReadLine().Split(' ');
            byte[] ArrayStr = new byte[Str.Length];
            for (int i = 0; i < Str.Length; i++) ArrayStr[i] =Convert.ToByte(Str[i]);

            //записать массива в бинарный файл.
            File.WriteAllBytes("bytes.bin", ArrayStr);
        }
    }
}
