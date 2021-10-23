using System;
using System.Linq;
using System.Text;
using System.IO;

namespace Сourse_work
{
    class Program
    {
        static void Main(string[] args)
        {
            //название проекта
            Console.Title = "Курсовая работа \"Файловый менеджер\"";
            //размер консоли по всему экрану
            Console.SetBufferSize(Console.LargestWindowWidth, Console.LargestWindowHeight);
            Console.SetWindowSize(Console.LargestWindowWidth, Console.LargestWindowHeight);
            //консоль синего цвета
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Clear();
            //цвет текста
            Console.ForegroundColor = ConsoleColor.White;
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine($"{new string('=', Console.LargestWindowWidth - 2)}");
            Console.SetCursorPosition(0, 1);
            for (int i = 0; i < Console.LargestWindowHeight - 14; i++) Console.WriteLine ($"‖{new string(' ', Console.LargestWindowWidth - 3)}‖");
            Console.WriteLine($"{new string('=', Console.LargestWindowWidth - 2)}");
            for(int i = 0; i < 12; i++) Console.WriteLine($"‖{new string(' ', Console.LargestWindowWidth -3)}‖");
            Console.WriteLine($"{new string('=', Console.LargestWindowWidth - 2)}");

            //Вывод подкаталогов
            Console.SetCursorPosition(3,0);
            Console.WriteLine("...");
            string dirName = "C:\\";
            if (Directory.Exists(dirName))
            {
                string[] dirs = Directory.GetDirectories(dirName);
                foreach (string s in dirs)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.SetCursorPosition(3, Console.CursorTop);
                    Console.WriteLine(s.Replace(dirName, ""));
                }
                Console.SetCursorPosition(3, Console.CursorTop);
                Console.WriteLine();
                string[] files = Directory.GetFiles(dirName);
                foreach (string s in files)
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.SetCursorPosition(3, Console.CursorTop);
                    Console.WriteLine(s.Replace(dirName, ""));
                }
            }

            Console.ReadLine();
        }
    }
}
