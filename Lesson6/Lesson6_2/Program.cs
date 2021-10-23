using System;

namespace Lesson6_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int positiveNumber = 1;
            Random rand = new Random();

            int[] NumArray = new int[rand.Next(50)];

            for (int i = 0; i < NumArray.Length; i++)
            { 
                NumArray[i] = rand.Next(-100,100);
            }
            Array.Sort(NumArray);
            for (int i = 0; i < NumArray.Length; i++)
            {
                Console.Write(NumArray[i] + " ");
            }
            if (NumArray[0] < 0)
            {
                for (int i = 1; i < NumArray.Length; i++)
                {
                    if (NumArray[i] > 0)
                    {
                        positiveNumber = NumArray[i] - 1; 
                        break;
                    }
                }

            }
            else {
                for (int i = 0; i < NumArray.Length; i++)
                {
                    if ((NumArray[i+1] - NumArray[i]) > 1)
                    {
                        positiveNumber = NumArray[i] + 1;
                        break;
                    }
                    positiveNumber = NumArray[NumArray.Length-1] + 1;
                }

            }
            Console.WriteLine(" ");
            Console.WriteLine(positiveNumber);
        }
    }
}
