using System;
using System.Linq;
/*Домашнее задание:
 * Найти самый длинный палиндром в строке 
 */
namespace Lesson3_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string s;
            while ((s = Console.ReadLine()) != null)
                Console.WriteLine(new string(s.Reverse().ToArray()));
        }
    }
}
