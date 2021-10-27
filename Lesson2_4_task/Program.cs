﻿using System;
using System.Drawing;
using System.Drawing.Imaging;
/*
 * Домашнее задание
Для полного закрепления понимания простых типов найдите любой чек,
либо фотографию этого чека в интернете и схематично нарисуйте его в консоли,
только за место динамических, по вашему мнению, данных 
(это может быть дата, название магазина, сумма покупок) 
подставляйте переменные, которые были заранее заготовлены до вывода на консоль.
*/

namespace Lesson2_4_task
{
    class Program
    {
        static void Main(string[] args)
        {
            string Product, NameShop;
            int NumProduct, Price;
            //ввод параметров
            Console.WriteLine("Введите наименование магазина");
            NameShop = Console.ReadLine();
            Console.WriteLine("Введите наименование продукта");
            Product = Console.ReadLine();
            Console.WriteLine($"Количество {Product}");
            NumProduct = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Цена");
            Price = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("**********************************");
            Console.WriteLine("      НИЗКИЕ ЦЕНЫ КАЖДЫЙ ДЕНЬ    *");
            Console.WriteLine("**********************************");
            Console.WriteLine($"*    ООО \"{NameShop}\"         *");
            Console.WriteLine("*         111111, г.Самара       *");
            Console.WriteLine("*         ИНН 1122334455         *");
            Console.WriteLine("**********************************");
            Console.WriteLine("ПРОДАЖА                #0123/00543");
            Console.WriteLine("                                  ");
            Console.WriteLine($"Шрифт коссаовый \"{NameShop}\"   ");
            Console.WriteLine($"{NameShop}               {Price} * {NumProduct} шт.   {Price * NumProduct}");
            Console.WriteLine($"ИТОГ:                    {Price * NumProduct}");
            Console.WriteLine($"Наличные                 {Price * NumProduct}");
            Console.WriteLine("СДАЧА                         0.00");
            Console.WriteLine("***********************************");
            Console.WriteLine("********СПасибо за покупку!********");
            Console.WriteLine("Ждем Вас каждый день с 8-00 до 22-00");
            Console.WriteLine("************************************");
            Console.WriteLine("********ЯВЛЯЕТСЯ ТОВАРНЫМ ЧЕКОМ******");

        }
    }
}