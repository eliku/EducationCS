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

            Console.WriteLine("АБВГДЕЖЗИК");

            DeskShip(4, SeaBattleArray); //4 палубный корабль
            DeskShip(3, SeaBattleArray); //3 палубный корабль
            DeskShip(3, SeaBattleArray); //3 палубный корабль
            DeskShip(2, SeaBattleArray); //2 палубный корабль
            DeskShip(2, SeaBattleArray); //2 палубный корабль
            DeskShip(2, SeaBattleArray); //2 палубный корабль
            DeskShip(1, SeaBattleArray); //1 палубный корабль
            DeskShip(1, SeaBattleArray); //1 палубный корабль 
            DeskShip(1, SeaBattleArray); //1 палубный корабль
            DeskShip(1, SeaBattleArray); //1 палубный корабль

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    //Uncomment if (SeaBattleArray[i, j] != 'X') SeaBattleArray[i, j] = 'O';
                    Console.Write(SeaBattleArray[i, j]);
                }
                Console.WriteLine(i + 1);
            }
        }
        //Проверка на расположение к другим кораблям по вертикале
        static int CheckShipVert(int Col, int Row, char[,] Array, int Num)
        {
            if (Col != 0 && Col != 9)
            {
                if (Row != 0 && Row < 9 - Num)
                {
                    for (int i = Col - 1; i < Col + 2; i++)
                    {
                        for (int j = Row - 1; j < Row + Num + 2; j++)
                        {
                            if (Array[i, j] == 'X')
                            {
                                return 0;
                            }
                            if (i == Col + 1 && j == Row + Num + 1)
                            {
                                return 1;
                            }
                        }
                    }
                }
                else
                {
                    if (Row == 0)
                    {
                        for (int i = Col - 1; i < Col + 2; i++)
                        {
                            for (int j = 0; j < Num + 1; j++)
                            {
                                if (Array[i, j] == 'X')
                                {
                                    return 0;
                                }
                                if (i == Col + 1 && j == Num)
                                {
                                    return 1;
                                }
                            }
                        }
                    }
                    if (Row >= 9 - Num)
                    {
                        for (int i = Col - 1; i < Col + 2; i++)
                        {
                            for (int j = 9 - Num; j < 10; j++)
                            {
                                if (Array[i, j] == 'X')
                                {
                                    return 0;
                                }
                                if (i == Col + 1 && j == 9)
                                {
                                    return 1;
                                }
                            }

                        }
                    }
                }
                return 0;
            }
            else
            {
                int k, m;
                if (Row == 0) k = 0;
                else k = Row - 1;
                if (Row == 9 - Num) m = Row ;
                else m = Row + 1;

                for (int j = k; j < m; j++)
                {
                    if (Array[Col, j] == 'X')
                    {
                        return 0;
                    }
                    if (j == Row + Num)
                    {
                        return 1;
                    }
                }
                return 0;
            }
        }
        static int CheckShipHoriz(int Col, int Row, char[,] Array, int Num)
        {
            if (Row != 0 && Row != 9)
            {
                if (Col != 0 && Col < 9 - Num)
                {
                    for (int i = Col - 1; i < Col + Num; i++)
                    {
                        for (int j = Row - 1; j < Row + 2; j++)
                        {
                            if (Array[i, j] == 'X')
                            {
                                return 0;
                            }
                            if (i == Col + Num + 1 && j == Row + 1)
                            {
                                return 1;
                            }
                        }
                    }
                }
                else
                {
                    if (Col == 0)
                    {
                        for (int i = 0; i < Num + 1; i++)
                        {
                            for (int j = Row - 1; j < Row + 2; j++)
                            {
                                if (Array[i, j] == 'X')
                                {
                                    return 0;
                                }
                                if (i == Num && j == Row + 1)
                                {
                                    return 1;
                                }
                            }
                        }
                    }
                    if (Col >= 9 - Num)
                    {
                        for (int i = 9 - Num; i < 10; i++)
                        {
                            for (int j = Row - 1; j < Row + 2; j++)
                            {
                                if (Array[i, j] == 'X')
                                {
                                    return 0;
                                }
                                if (i == 9 && j == Row + 1)
                                {
                                    return 1;
                                }
                            }

                        }
                    }

                }
                return 0;
            }
            else 
            {
                int k, m;
                if (Col == 0) k = 0;
                else k = Col - 1;
                if (Col == 9 - Num) m = Col;
                else m = Col + 1;

                for (int j = k; j < m; j++)
                {
                    if (Array[j, Row] == 'X')
                    {
                        return 0;
                    }
                    if (j == Col + Num)
                    {
                        return 1;
                    }
                }
                return 0;
            }
        }
        static void DeskShip(int Cnt, char[,] Array)
        {
            //число для генерации положения корабля
            int RamdomNum, RamdomRow, RamdomCol;

            //Создание объекта для генерации чисел
            Random rnd = new Random();

            RamdomNum = rnd.Next(0, 2);
            if (RamdomNum == 1) //вертикальное положение
            {
                RamdomCol = rnd.Next(0, 9);      //выбираем столбец
                RamdomRow = rnd.Next(0, 9 - Cnt);//выбираем строку

                while (CheckShipVert(RamdomCol, RamdomRow, Array, Cnt) == 0)
                {
                    RamdomCol = rnd.Next(0, 9);      //выбираем столбец
                    RamdomRow = rnd.Next(0, 9 - Cnt);//выбираем строку
                }
            
                for (int i = RamdomRow; i < RamdomRow + Cnt; i++)
                {
                    //Array[RamdomCol, i] = 'X';
                    Array[i, RamdomCol] = 'X';
                }
            }
            else
            { //горизонтальное положение
                RamdomRow = rnd.Next(0, 9);      //выбираем строку
                RamdomCol = rnd.Next(0, 9 - Cnt);//выбираем столбец

                while (CheckShipHoriz(RamdomRow, RamdomCol, Array, Cnt) == 0)
                {
                    RamdomRow = rnd.Next(0, 9);      //выбираем строку
                    RamdomCol = rnd.Next(0, 9 - Cnt);//выбираем столбец
                }
                for (int i = RamdomCol; i < RamdomCol + Cnt; i++)
                {
                    // Array[i, RamdomRow] = 'X';
                   // Array[RamdomRow,i] = 'X';
                }
            }
        }
    }
}
