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
                string[] dirs = Directory.GetDirectories(Dir);
                File.AppendAllLines(name, dirs);
            }
        }
        static void Main(string[] args)
        {
            string dirName = @"L:\Education\EducationCS\Lesson5\Lesson5_4\bin\Debug\net5.0";
            int count = 0;
            for (int i = 0; i < dirName.Length; i++) 
            {
                if (dirName[i] == '\\') count++;
            }

            var word = dirName.Split('\\');

            //Getsubdirectory(words, "Text.txt");
        }
    }
}
