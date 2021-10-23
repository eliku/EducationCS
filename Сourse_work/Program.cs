﻿using System;
using System.Text;
using System.IO;
using System.Collections.Generic;

namespace Сourse_work
{
    class Program
    {
        static void Main(string[] args)
        {
            //список строк подкаталогов и файлов
            List<string> listCatalog = new List<string>();
            //количество файлов
            int FileCnt=0;
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
            //прорисовка экрана
            Console.WriteLine($"{new string('=', Console.LargestWindowWidth - 2)}");
            Console.SetCursorPosition(0, 1);
            for (int k = 0; k < Console.LargestWindowHeight - 14; k++) Console.WriteLine ($"‖{new string(' ', Console.LargestWindowWidth - 3)}‖");
            Console.WriteLine($"{new string('=', Console.LargestWindowWidth - 2)}");
            for(int k = 0; k < 12; k++) Console.WriteLine($"‖{new string(' ', Console.LargestWindowWidth -3)}‖");
            Console.WriteLine($"{new string('=', Console.LargestWindowWidth - 2)}");
            
            //Вывод подкаталогов
            string dirName = "C:\\";
            FileCnt = OutDirectory(dirName, ref listCatalog);
            var directory = new DirectoryInfo(dirName);
            //Вывод информации
            if (directory.Exists) // Если указанная директория существует, то выводим о ней информацию.
            {
                Console.SetCursorPosition(3, Console.LargestWindowHeight - 14);
                Console.WriteLine($"Имя {directory.FullName}");
                Console.SetCursorPosition(3, Console.LargestWindowHeight - 13);
                Console.WriteLine($"Время создания {directory.CreationTime}");
            }
            // обработка нажатий кнопок
            int PositionCursore = 1;
            ConsoleKey key = Console.ReadKey().Key;
            while (key != ConsoleKey.Escape)
            {
                Console.CursorVisible = false;
                switch (key)
                {
                    case ConsoleKey.UpArrow://клавиша вверх
                        { 
                            if (PositionCursore > 0)
                            {
                                Console.SetCursorPosition(3, PositionCursore);
                                Console.BackgroundColor = ConsoleColor.Blue;
                                if (PositionCursore<=listCatalog.Count - FileCnt) Console.ForegroundColor = ConsoleColor.White;
                                else                                              Console.ForegroundColor = ConsoleColor.Black;
                                Console.WriteLine(listCatalog[PositionCursore - 1]);
                                PositionCursore--;
                                Console.SetCursorPosition(3, PositionCursore);
                                Console.BackgroundColor = ConsoleColor.Gray;
                                Console.ForegroundColor = ConsoleColor.White;
                                if (PositionCursore == 0) Console.WriteLine("...");
                                else                      Console.WriteLine(listCatalog[PositionCursore - 1]);

                                if (PositionCursore != 0)
                                {
                                    directory = new DirectoryInfo(dirName + listCatalog[PositionCursore - 1]);
                                    //Вывод информации
                                    OutInfoDirectory(directory);
                                }

                            }
                            break;

                        }
                    case ConsoleKey.DownArrow://клавиша вниз
                        {
                            if (PositionCursore < Console.LargestWindowHeight - 15 && PositionCursore<listCatalog.Count)
                            {
                                Console.SetCursorPosition(3, PositionCursore);
                                Console.BackgroundColor = ConsoleColor.Blue;
                                if (PositionCursore <= listCatalog.Count - FileCnt) Console.ForegroundColor = ConsoleColor.White;
                                else Console.ForegroundColor = ConsoleColor.Black;
                                if (PositionCursore == 0) Console.WriteLine("...");
                                else                      Console.WriteLine(listCatalog[PositionCursore - 1]);
                                PositionCursore++;
                                Console.SetCursorPosition(3, PositionCursore);
                                Console.BackgroundColor = ConsoleColor.Gray;
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine(listCatalog[PositionCursore - 1]);
                                if (PositionCursore != 0)
                                {
                                    directory = new DirectoryInfo(dirName + listCatalog[PositionCursore - 1]);
                                    //Вывод информации
                                    OutInfoDirectory(directory);
                                }
                            }

                            break;
                        }
                }

                key = Console.ReadKey().Key;
            }
            Console.ReadLine();
        }

        //метод вывода подкаталогов и файлов
        public static int OutDirectory(string dirName, ref List<string> list)
        {

            Console.SetCursorPosition(3, 0);
            Console.WriteLine("...");
            list.Clear();
            int FileCnt = 0;

            if (Directory.Exists(dirName))
            {
                string[] dirs = Directory.GetDirectories(dirName);
                foreach (string s in dirs)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.SetCursorPosition(3, Console.CursorTop);
                    Console.WriteLine(s.Replace(dirName, ""));
                    list.Add(s.Replace(dirName, ""));
                }
                string[] files = Directory.GetFiles(dirName);
                FileCnt = files.Length;
                foreach (string s in files)
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.SetCursorPosition(3, Console.CursorTop);
                    Console.WriteLine(s.Replace(dirName, ""));
                    list.Add(s.Replace(dirName, ""));
                }
            }
            return FileCnt;
        }
        //метод вывода информации о каталоге
        public static void OutInfoDirectory(DirectoryInfo dirName)
        {
            if (dirName.Exists) // Если указанная директория существует, то выводим о ней информацию.
            {
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.SetCursorPosition(3, Console.LargestWindowHeight - 14);
                Console.WriteLine($"Имя {dirName.FullName}                                                   ");
                Console.SetCursorPosition(3, Console.LargestWindowHeight - 13);
                Console.WriteLine($"Время создания {dirName.CreationTime}                                    ");
            }
        }
    }
}
