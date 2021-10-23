using System;
using System.IO;

/* Домашнее задание
 * Сохранить дерево каталогов и файлов по заданному пути в текстовый файл — с рекурсией и без.
 */

namespace Lesson5_4
{
    class Program
    {

        public static void Getsubdirectory(string Dir, string name)
        {
            if (Directory.Exists(Dir))
            {
                File.AppendAllText(name,  "Подкаталог");
                string[] dirs = Directory.GetDirectories(Dir);
                File.AppendAllLines(name, dirs);
                dirs = Directory.GetFiles(Dir);
                File.AppendAllLines(name, dirs);
            }
        }

        public static string Getsubrecycle(string Dir, string name)
        {
            if (Directory.Exists(Dir))
            {
                File.AppendAllText(name, "Подкаталог");
                string[] dirs = Directory.GetDirectories(Dir);
                File.AppendAllLines(name, dirs);
                dirs = Directory.GetFiles(Dir);
                File.AppendAllLines(name, dirs);
                for (int i = Dir.Length - 2; i > 0; i--)
                {
                    if (Dir[i] == '\\')
                    {
                         return (Getsubrecycle(Dir.Substring(0, i + 1), name));
                    }
                }
                return "";
            } 
            else return "";
        }

        static void Main(string[] args)
        {
            string dirName = @"L:\Education\EducationCS\Lesson5\Lesson5_4\bin\Debug\net5.0\";

            for (int i = 0; i < dirName.Length; i++) 
            {
                if (dirName[i] == '\\')
                {
                    Getsubdirectory(dirName.Substring(0, i+1), "Text.txt");
                }
            }

            Getsubrecycle(dirName, "Text2.txt");


        }
    }
}
