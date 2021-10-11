using System;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Lesson5_5
{
    public class ToDolist
    {
        //поля класса
        public string Title { get; set; }
        public string IsDone { get; set; }

        // Метод, записывает новую задачу
        public static  void Write(string TitleStr, string StrDone, string path)
        {
            var listNew = new ToDolist
            {
                Title = TitleStr,
                IsDone = StrDone,
            };
            //дописывает текущее время в файл «startup.txt»
            File.AppendAllLines(path, new[] { JsonSerializer.Serialize(listNew)});
        }

    }
}
