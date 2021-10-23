using System;
using System.Diagnostics;

/* Домашнее задание
 * Написать консольное приложение Task Manager, которое выводит на экран запущенные процессы и позволяет завершить указанный процесс. 
 * Предусмотреть возможность завершения процессов с помощью указания его ID или имени процесса. 
 * В качестве примера можно использовать консольные утилиты Windows tasklist и taskkill.
 */

namespace Lesson6
{
    class Program
    {
        static void Main(string[] args)
        {
            Process[] listprosecc = Process.GetProcesses();

            foreach (Process outProcess  in listprosecc)
            {
                // выводим id и имя процесса
                Console.WriteLine($"ID: {outProcess.Id}  Name: {outProcess.ProcessName}");
            }

            Console.WriteLine("Введите ID или имени процесса");
            //ввод имени или ID процесса
            string IDorName = Console.ReadLine();

            foreach (Process outProcess in listprosecc)
            {
                // выводим id и имя процесса
                if (outProcess.ProcessName == IDorName) 
                {
                    outProcess.Kill();
                }

                if (outProcess.Id == Convert.ToInt32(IDorName)) 
                {
                    outProcess.Kill();
                }
            }
        }
    }
}
