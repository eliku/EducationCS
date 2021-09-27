using System;

namespace Lesson2_7_task
{
    class Program
    {
        static void Main(string[] args)
        {
            //блок переменных
            string Str;
            int result = 0;

            //локальная функция нахождения повторяющихся символов
            int FindRepeatChar(char AChar, int AValue)
            {
                for (int i = 0; i < Str.Length; i++)
                {
                    if (Str[i] == AChar && Str[i + 1] == AChar)
                    {
                        if (Str[i + 2] == AChar) { result += 3 * AValue; Str = Str.Remove(i, 3); return result; }
                        else { result += 2 * AValue; Str = Str.Remove(i, 2); return result; }
                    }
                }
                return result;
            }

            //ввод пользователем римской цифры
            Console.WriteLine("Введите число в римском представлении");
            Str = Console.ReadLine();

            //Повтор римской цифры M
            FindRepeatChar('M', 1000);
            //Повтор римской цифры C
            FindRepeatChar('C', 100);
            //Повтор римской цифры X
            FindRepeatChar('X', 10);
            //Повтор римской цифры I
            FindRepeatChar('I', 1);

            int[] Array = new int[Str.Length];
            for (int i = 0; i < Str.Length; i++)
            {
                switch (Str[i])
                {
                    case 'I': //1
                        Array[i] = 1;
                        break;
                    case 'V'://5
                        Array[i] = 5;
                        break;
                    case 'X'://10
                        Array[i] = 10;
                        break;
                    case 'L'://50
                        Array[i] = 50;
                        break;
                    case 'C'://100
                        Array[i] = 100;
                        break;
                    case 'D'://500
                        Array[i] = 500;
                        break;
                    case 'M'://1000
                        Array[i] = 1000;
                        break;
                    default:
                        Array[i] = 0;
                        break;
                }
            }

            for (int i = 0; i < Str.Length; i++)
            {
                Console.Write(Str[i]);
            }
            Console.WriteLine(result);
        }
    }
}
