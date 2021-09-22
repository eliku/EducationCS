using System;

namespace Lesson_1_star
{
    class Program
    {
        static void Main(string[] args)
        {
            //перебор всех цифр от 1 до 100
            for (int i = 1; i <= 100; i++) 
            {
                //если число делиться на 3 и на 5
                if ((i % 3 == 0) && (i % 5 == 0))
                {
                    Console.Write("FizzBuzz,");
                }
                else
                {
                    //если число делиться на 3
                    if (i % 3 == 0)
                    {
                        Console.Write("Fizz,");
                    }
                    else
                    {
                        //если число делиться на 5
                        if (i % 5 == 0)
                        {
                            Console.Write("Buzz,");
                        }
                        else
                        {
                            //вывод в консоль цифр
                            Console.Write($"{i},");
                        }
                    }
                }
            }
        }
    }
}
