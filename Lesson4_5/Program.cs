using System;
using System.Linq;

/*Домашнее задание
 * Вычислить медиану двух матриц 
 */
namespace Lesson4_5
{
    class Program
    {
        static public void GetArray(string Str, out int[] myArray)
        {
            string[] subs = Str.Split(' ');
            myArray = new int[subs.Length];
            for (int i = 0; i < subs.Length; i++)
            {
                myArray[i] = Convert.ToInt32(subs[i]);
            }
        }
        static public void Main(string[] args)      
        {
            //Инициализация массивов
            int[] ArrayOne, ArrayTwo, NewArray;
            double Mediana = 0;

            //ввод массивов
            Console.WriteLine("Введите первый массив чисел через пробел");
            GetArray(Console.ReadLine(), out ArrayOne);
            Console.WriteLine("Введите второй массив чисел через пробел");
            GetArray(Console.ReadLine(), out ArrayTwo);
            //Объединение массивов и сортировка
            NewArray = ArrayOne.Concat(ArrayTwo).ToArray();
            Array.Sort(NewArray);

            int index = NewArray.Length / 2;

            if (NewArray.Length % 2 == 0)
            {
                
                Mediana = (NewArray[index - 1] + NewArray[index]) / 2.0;
            }
            else {
                Mediana = NewArray[index];
            }

            Console.WriteLine($"Медиана равна {Mediana}");

        }


    }
}
