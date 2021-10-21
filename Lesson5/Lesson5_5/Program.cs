using System;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

/* Домашнее задание
 * Список задач (ToDo-list):
 * написать приложение для ввода списка задач;
 * задачу описать классом ToDo с полями Title и IsDone;
 * на старте, если есть файл tasks.json/xml/bin (выбрать формат), загрузить из него массив имеющихся задач и вывести их на экран;
 * если задача выполнена, вывести перед её названием строку «[x]»;
 * вывести порядковый номер для каждой задачи;
 * при вводе пользователем порядкового номера задачи отметить задачу с этим порядковым номером как выполненную;
 * записать актуальный массив задач в файл tasks.json/xml/bin.
 */

namespace Lesson5_5
{
    class Program
    {

        static void Main(string[] args)
        {
            int i;
            Console.WriteLine("Введите Title и IsDone");
            ToDolist.Write(Console.ReadLine(), Console.ReadLine(), @"serializ.txt");

            string[] lines = File.ReadAllLines(@"serializ.txt");
            i = 0; 
            foreach (string s in lines)
            {
                i++;
                Console.WriteLine($"{i}. {s}");
            }
        }
    }
}
