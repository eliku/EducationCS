using System;
using System.Linq;

/*Домашнее задание
 * Вычислить медиану двух матриц 
 */
namespace Lesson4_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите числа первого массива через пробел");
            string[] subs =(Console.ReadLine()).Split(' ');
            int[] ArrayOne = new int[subs.Length];

            Console.WriteLine("Введите числа второго массива через пробел");
            subs = (Console.ReadLine()).Split(' ');
            int[] ArrayTwo = new int[subs.Length];
            //сортировка массива
            int[] AllArray = ArrayOne.Concat(ArrayTwo).ToArray();
            Array.Sort(AllArray);


            
        }
    }
}
