using System;
using System.Text;
using System.IO;
using System.Collections.Generic;
using System.Configuration;
using System.Threading;

namespace Сourse_work
{
    class Program
    {
        static int PositionCursore = 1;
        //список строк подкаталогов и файлов
        static List<string> listCatalog = new List<string>();
        //количество файлов
        static int FileCnt = 0;
        static DirectoryInfo directory;
        static string dirName;
        static Configuration configFile;
        static KeyValueConfigurationCollection settings;
        static int Size = 0;
        static private object valueLocker = new object();
        public static void Main(string[] args)
        {
            //многопоточность
            Thread myThread = new Thread(new ThreadStart(readLine));
            Thread myThreadKey = new Thread(new ThreadStart(keyread));
            //сохранение конфигурации
            configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            settings = configFile.AppSettings.Settings;

            if (settings["Direction"] == null)
            {
                settings.Add("Direction", "C:\\");
                //Вывод подкаталогов
                dirName = "C:\\";
            }
            else {
                dirName = settings["Direction"].Value;
            }
            //название проекта
            Console.Title = "Курсовая работа \"Файловый менеджер\"";
            //размер консоли по всему экрану
            Console.SetBufferSize(Console.LargestWindowWidth, Console.LargestWindowHeight);
            Console.SetWindowSize(Console.LargestWindowWidth, Console.LargestWindowHeight);
            //консоль синего цвета
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Clear();
            Console.OutputEncoding = Encoding.UTF8;
            Size = Console.LargestWindowHeight;

            OutConcole(dirName, ref FileCnt, ref listCatalog, ref PositionCursore);

            FileCnt = OutDirectory(dirName, ref listCatalog);
            directory = new DirectoryInfo(dirName);
            //Вывод информации
            if (directory.Exists) // Если указанная директория существует, то выводим о ней информацию.
            {
                Console.SetCursorPosition(3, Console.LargestWindowHeight - 14);
                Console.WriteLine($"Имя {directory.FullName}");
                Console.SetCursorPosition(3, Console.LargestWindowHeight - 13);
                Console.WriteLine($"Время создания {directory.CreationTime}");
            }
            // обработка нажатий кнопок
            myThreadKey.Start();
            myThread.Start();
            

        }

        public static void readLine()
        {
            string name;
            bool end = true;
            lock (valueLocker)
            {
                Console.SetCursorPosition(3, Size - 1);
                do
                {
                    name = Console.ReadLine();
                    Console.SetCursorPosition(3, Size - 1);

                    switch (name)
                    {
                        case "Help":
                            Console.WriteLine("Info -Выводит список файлов в каталоге\nCD-Переход в каталог\nDel-Удаление файла по имени\nDelM-Удаление файла по маске\nCrea-Создание файла\nCopy-Копирование файла");
                            break;
                        case "Exit":
                            end = false;
                            break;
                        default:
                            break;
                    }
                    OutConcole(dirName, ref FileCnt, ref listCatalog, ref PositionCursore);
                    Thread.Sleep(50);

                } while (end != false);
            }
        }

        public static void keyread()
        {
            ConsoleKey key = Console.ReadKey().Key;
            while (key != ConsoleKey.Escape)
            {
                Console.CursorVisible = true;
                Console.SetCursorPosition(3, PositionCursore);
                switch (key)
                {
                    case ConsoleKey.UpArrow://клавиша вверх
                        {
                            if (PositionCursore > 0)
                            {
                                Console.SetCursorPosition(3, PositionCursore);
                                Console.BackgroundColor = ConsoleColor.Blue;
                                if (PositionCursore <= listCatalog.Count - FileCnt) Console.ForegroundColor = ConsoleColor.White;
                                else Console.ForegroundColor = ConsoleColor.Black;
                                Console.WriteLine(listCatalog[PositionCursore - 1]);
                                PositionCursore--;
                                Console.SetCursorPosition(3, PositionCursore);
                                Console.BackgroundColor = ConsoleColor.Gray;
                                Console.ForegroundColor = ConsoleColor.White;
                                if (PositionCursore == 0) Console.WriteLine("...");
                                else Console.WriteLine(listCatalog[PositionCursore - 1]);

                                if (PositionCursore != 0 && PositionCursore <= listCatalog.Count - FileCnt)
                                {
                                    directory = new DirectoryInfo(dirName + listCatalog[PositionCursore - 1]);
                                    //Вывод информации
                                    OutInfoDirectory(directory);
                                }
                                if (PositionCursore > listCatalog.Count - FileCnt) OutInfoFile(dirName + listCatalog[PositionCursore - 1]);
                            }
                            break;

                        }
                    case ConsoleKey.DownArrow://клавиша вниз
                        {
                            if (PositionCursore < Console.LargestWindowHeight - 15 && PositionCursore < listCatalog.Count)
                            {
                                Console.SetCursorPosition(3, PositionCursore);
                                Console.BackgroundColor = ConsoleColor.Blue;
                                if (PositionCursore <= listCatalog.Count - FileCnt) Console.ForegroundColor = ConsoleColor.White;
                                else Console.ForegroundColor = ConsoleColor.Black;
                                if (PositionCursore == 0) Console.WriteLine("...");
                                else Console.WriteLine(listCatalog[PositionCursore - 1]);
                                PositionCursore++;
                                Console.SetCursorPosition(3, PositionCursore);
                                Console.BackgroundColor = ConsoleColor.Gray;
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine(listCatalog[PositionCursore - 1]);
                                if (PositionCursore != 0 && PositionCursore <= listCatalog.Count - FileCnt)
                                {
                                    directory = new DirectoryInfo(dirName + listCatalog[PositionCursore - 1]);
                                    //Вывод информации
                                    OutInfoDirectory(directory);
                                }
                                if (PositionCursore > listCatalog.Count - FileCnt) OutInfoFile(dirName + listCatalog[PositionCursore - 1]);
                            }

                            break;
                        }
                    case ConsoleKey.Enter:
                        if (PositionCursore != 0)
                        {
                            dirName = dirName + listCatalog[PositionCursore - 1];
                            //очищение конфигурации
                            settings.Remove("Direction");
                            //сохранение новых конфигураций
                            settings.Add("Direction", dirName);
                            OutConcole(dirName, ref FileCnt, ref listCatalog, ref PositionCursore);
                            configFile.Save(ConfigurationSaveMode.Modified);
                            ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name);
                        }
                        else
                        {
                            for (int i = settings["Direction"].Value.Length - 2; i > 0; i--)
                            {
                                if (settings["Direction"].Value[i] == '\\')
                                {
                                    dirName = settings["Direction"].Value.Substring(0, i + 1);
                                    //очищение конфигурации
                                    settings.Remove("Direction");
                                    //сохранение новых конфигураций
                                    settings.Add("Direction", dirName);
                                    OutConcole(dirName, ref FileCnt, ref listCatalog, ref PositionCursore);
                                    configFile.Save(ConfigurationSaveMode.Modified);
                                    ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name);
                                    break;
                                }
                            }
                        }
                        Console.SetCursorPosition(3, Size - 1);
                        break;
                    case ConsoleKey.End:
                        // Console.
                        break;
                }
                Thread.Sleep(50);
                key = Console.ReadKey().Key;
                Console.SetCursorPosition(3, Size - 1);
            }
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
            Console.SetCursorPosition(3, Size-1);
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
        public static void OutInfoFile(string path)
        {
            FileInfo fileInf = new FileInfo(path);
            if (fileInf.Exists)
            {
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.SetCursorPosition(3, Console.LargestWindowHeight - 14);
                Console.WriteLine($"Имя файла: {fileInf.Name}                                                 ");
                Console.SetCursorPosition(3, Console.LargestWindowHeight - 13);
                Console.WriteLine($"Время создания: {fileInf.CreationTime}                                    ");
                Console.SetCursorPosition(3, Console.LargestWindowHeight - 12);
                Console.WriteLine($"Размер: {fileInf.Length}                                                  ");
            }
        }

        public static void OutConcole(string DirName, ref int FileCnt, ref List<string> listCatalog, ref int PositionCursore)
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Clear();
            //прорисовка экрана
            Console.WriteLine($"{new string('=', Console.LargestWindowWidth - 2)}");
            Console.SetCursorPosition(0, 1);
            for (int k = 0; k < Console.LargestWindowHeight - 14; k++) Console.WriteLine($"‖{new string(' ', Console.LargestWindowWidth - 3)}‖");
            Console.WriteLine($"{new string('=', Console.LargestWindowWidth - 2)}");
            for (int k = 0; k < 12; k++) Console.WriteLine($"‖{new string(' ', Console.LargestWindowWidth - 3)}‖");
            Console.WriteLine($"{new string('=', Console.LargestWindowWidth - 2)}");

            //Вывод подкаталогов
            FileCnt = OutDirectory(DirName, ref listCatalog);

            var directory = new DirectoryInfo(DirName);
            //Вывод информации
            if (directory.Exists) // Если указанная директория существует, то выводим о ней информацию.
            {
                Console.SetCursorPosition(3, Console.LargestWindowHeight - 14);
                Console.WriteLine($"Имя {directory.FullName}");
                Console.SetCursorPosition(3, Console.LargestWindowHeight - 13);
                Console.WriteLine($"Время создания {directory.CreationTime}");
            }
            // обработка нажатий кнопок
            PositionCursore = 1;
        }
    }
}
