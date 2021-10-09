using System;
using System.IO;

/* Домашнее задание
 * Сохранить дерево каталогов и файлов по заданному пути в текстовый файл — с рекурсией и без.
 */

namespace Lesson5_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string workDir = @"C:\Program Files (x86)\Microsoft.NET";

            // Перечень всех файлов и папок, вложенных в workDir
            string[] entries = Directory.GetFileSystemEntries(workDir, "*", SearchOption.AllDirectories);

            for (int i = 0; i < entries.Length; i++)
            {
                Console.WriteLine(entries[i]);
            }

        }
    }
}
