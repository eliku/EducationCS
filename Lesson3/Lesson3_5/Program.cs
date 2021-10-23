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
            Console.WriteLine("Введите строку.");
            string Str = Console.ReadLine();
            char[] ArrayCopy = new char[1];
            ArrayCopy[0] = Str[0];
            // Array.Resize(ref arr, 10);
             for (int i = 0; i < Str.Length-1; i++)
             {
                 for (int j = i+1; j < Str.Length; j++)
                 {
                     string StrSub = Str.Substring(i, (j - i));
                     int k = StringComparison(StrSub);
                    if (k != 0 && k > ArrayCopy.Length)
                     {
                         Array.Resize(ref ArrayCopy, k);
                         for (int m = 0; m < k; m++) ArrayCopy[m] = StrSub[m];
                     }
                 }
             }
            for (int k = 0; k < ArrayCopy.Length; k++)
            {
                Console.Write(ArrayCopy[k]);
            }
              

        }
        static int StringComparison(string PartStr) 
        {
            string StrCopy = new String(PartStr.Reverse().ToArray());
            if (StrCopy == PartStr) return StrCopy.Length;
            return 0;
        }
    }
}
