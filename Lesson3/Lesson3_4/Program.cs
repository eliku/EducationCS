using System;
/*Домашнее задание
 * «Морской бой»: 
 * вывести на экран массив 10х10, состоящий из символов X и O, 
 * где Х — элементы кораблей, а О — свободные клетки. 
 */
namespace Lesson3_4
{
    class Program
    {
        static void Main(string[] args)
        {
            char[,] SeaBattleArray = new char[10, 10];
            //число для генерации положения корабля
            int RamdomNum, RamdomRow, RamdomCol;

            //Создание объекта для генерации чисел
            Random rnd = new Random();
            Console.WriteLine("АБВГДЕЖЗИК");

            void DeskShip (int Cnt)
            {
                //число для генерации положения корабля
                int RamdomNum, RamdomRow, RamdomCol;

                RamdomNum = rnd.Next(0, 2);
                if (RamdomNum == 1) //вертикальное положение
                {
                    RamdomCol = rnd.Next(1, 10);      //выбираем столбец
                    RamdomRow = rnd.Next(1, 11 - Cnt);//выбираем строку
                    for (int i = RamdomRow; i < RamdomRow + Cnt; i++)
                    {
                        SeaBattleArray[RamdomCol, i] = 'X';
                    }
                }
                else { //горизонтальное положение
                    RamdomRow = rnd.Next(1, 10);      //выбираем строку
                    RamdomCol = rnd.Next(1, 11 - Cnt);//выбираем столбец
                    for (int i = RamdomCol; i < RamdomCol + Cnt; i++)
                    {
                        SeaBattleArray[i, RamdomRow] = 'X';
                    }
                }
            }
            DeskShip(4); //4 палубный корабль
            DeskShip(3); //3 палубный корабль
            DeskShip(3); //3 палубный корабль
            DeskShip(2); //2 палубный корабль
            DeskShip(2); //2 палубный корабль
            DeskShip(2); //2 палубный корабль
            DeskShip(1); //1 палубный корабль
            DeskShip(1); //1 палубный корабль 
            DeskShip(1); //1 палубный корабль
            DeskShip(1); //1 палубный корабль

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (SeaBattleArray[i, j] != 'X') SeaBattleArray[i, j] = 'O';
                    Console.Write(SeaBattleArray[i, j]);
                }
                Console.WriteLine(i + 1);
            }
        }
    }
}
