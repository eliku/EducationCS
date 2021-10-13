using System;

namespace Lesson6_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            int[] NumArray = new int[rand.Next(0,50)];

            for (int i = 0; i < NumArray.Length; i++)
            { 
                NumArray[i] = rand.Next(-5, 5);
                Console.Write(NumArray[i]);
            }

        }
    }
}
