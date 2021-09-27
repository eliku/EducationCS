using System;

namespace Lesson2_6_task
{
    class Program
    {
        static void Main(string[] args)
        {
            int isWork = 0;
            string[] Days = { "в понедельник", "во вторник", "в cреду", "в четверг", "в пятницу", "в субботу", "в воскресенье" };

            Console.WriteLine("Вводим расписание офиса");
            //ввод работы офиса в понедельник
            Console.WriteLine("Офис работает в понедельник (да/нет)");
            if (Console.ReadLine()=="да") isWork = isWork | 0b000001;
            //ввод работы офиса во вторник
            Console.WriteLine("Офис работает во вторник (да/нет)");
            if (Console.ReadLine() == "да") isWork = isWork | 0b000010;
            //ввод работы офиса в среду
            Console.WriteLine("Офис работает в cреду (да/нет)");
            if (Console.ReadLine() == "да") isWork = isWork | 0b000100;
            //ввод работы офиса в четверг 
            Console.WriteLine("Офис работает в четверг (да/нет)");
            if (Console.ReadLine() == "да") isWork = isWork | 0b001000;
            //ввод работы офиса в пятницу
            Console.WriteLine("Офис работает в пятницу (да/нет)");
            if (Console.ReadLine() == "да") isWork = isWork | 0b010000;
            //ввод работы офиса в субботу 
            Console.WriteLine("Офис работает в субботу (да/нет)");
            if (Console.ReadLine() == "да") isWork = isWork | 0b100000;
            //ввод работы офиса в воскресенье 
            Console.WriteLine("Офис работает в воскресенье (да/нет)");
            if (Console.ReadLine() == "да") isWork = isWork | 0b1000000;

            if (isWork == 0)
            {
                Console.WriteLine("Офис не работает");
            }
            else
            {
                Console.Write("Офис работает ");
                for (int i = 0; i < 7; i++)
                {
                    if ((isWork & (int)Math.Pow(2, i)) == Math.Pow(2, i))
                    {
                        Console.Write($"{Days[i]},  ");
                    }
                }
            }
        }
    }
}
