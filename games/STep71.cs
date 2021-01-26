using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace games
{
    public class STep71 : STep7
    {
        public static List<string[]> step1 = new List<string[]>();
        public static bool gameStatus = true; //Статус игры

        public static string hero = "X"; //Герой
        public static string wall = "#"; //Стена
        public static string target = "1"; //Цель
        public static string target1 = "?"; //Цель
        public static string emptyCell = " "; //Пустая ячейка
        public static void Step71()
        {
            Console.SetWindowSize(130, 38);
            
            
            step1.Add(new string[] { "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#" });
            step1.Add(new string[] { "#", " ", " ", " ", " ", " ", " ", " ", " ", " ", "#", "1", "#", " ", " ", "#", "#", "#", "#", "#", "#", "#", "#", "#" });
            step1.Add(new string[] { "#", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "#", "#", "#", "#", "#", "#", "#", "#", "#" });
            step1.Add(new string[] { "#", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "#", "#", "#", "#", "#", "#", "#", "#", "#" });
            step1.Add(new string[] { "#", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "#" });
            step1.Add(new string[] { "#", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "#" });
            step1.Add(new string[] { "#", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "#" });
            step1.Add(new string[] { "#", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "X", " ", "#" });
            step1.Add(new string[] { "#", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "#" });
            step1.Add(new string[] { "#", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "?", "#" });
            step1.Add(new string[] { "#", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "#" });
            step1.Add(new string[] { "#", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "#", "#", " ", "#" });
            step1.Add(new string[] { "#", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "#", "#", " ", "#" });
            step1.Add(new string[] { "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#" });
            render();
            while (gameStatus)
            {
                var keyInfo = Console.ReadKey();
                moveHero(keyInfo);
                render();
            }
        }

        public static void render()
        {
            Console.Clear();
            for (int x = 0; x < step1.Count; x++)
            {
                Console.WriteLine(string.Join("", step1[x]));
            }

        }
        
        public static void inf()
        {
            Console.WriteLine("Я устал здесь находиться ");
            Thread.Sleep(2000);
            Console.WriteLine("Я сижу здесь уже несколько дней");
            Thread.Sleep(2000);
            Console.WriteLine("Я голоден и скучаю по родным");
            Thread.Sleep(2000);
            Console.WriteLine("Мне пора выбираться");
            Thread.Sleep(2000);
        }


        public static void New_level()
        {
            Console.Clear();
            Console.WriteLine("..................................ЭТАЖ 7..............................");
            Thread.Sleep(5000);
            Console.Clear();
            Step7();
        }


        static void moveHero(ConsoleKeyInfo keyInfo)
        {
            for (int x = step1.Count - 1; x >= 0; x--)
            {
                for (int y = 0; y < step1[x].Length; y++)
                {
                    if (step1[x][y] == hero)
                    {
                        if (keyInfo.Key == ConsoleKey.UpArrow)
                        {
                            if ((x - 1) >= 0 && step1[x - 1][y] == emptyCell)
                            {
                                step1[x][y] = emptyCell;
                                step1[x - 1][y] = hero;
                                return;
                            }
                            else if ((x - 1) >= 0 && step1[x - 1][y] == target)
                            {
                                step1[x][y] = emptyCell;
                                step1[x - 1][y] = hero;
                                New_level();

                                return;
                            }
                            else if ((x - 1) >= 0 && step1[x - 1][y] == target1)
                            {
                                step1[x][y] = emptyCell;
                                step1[x ][y] = hero;
                                inf();

                                return;
                            }
                        }
                        else if (keyInfo.Key == ConsoleKey.DownArrow)
                        {
                            if ((x + 1) <= (step1.Count - 1) && step1[x + 1][y] == emptyCell)
                            {
                                step1[x][y] = emptyCell;
                                step1[x + 1][y] = hero;
                                return;
                            }
                            else if ((x + 1) <= (step1.Count - 1) && step1[x + 1][y] == target)
                            {
                                step1[x][y] = emptyCell;
                                step1[x + 1][y] = hero;
                                New_level();
                                return;
                            }
                            else if ((x + 1) <= (step1.Count - 1) && step1[x + 1][y] == target1)
                            {
                                step1[x][y] = emptyCell;
                                step1[x][y] = hero;
                                inf();
                                return;
                            }
                        }
                        else if (keyInfo.Key == ConsoleKey.LeftArrow)
                        {
                            if ((y - 1) >= 0 && step1[x][y - 1] == emptyCell)
                            {
                                step1[x][y] = emptyCell;
                                step1[x][y - 1] = hero;
                                return;
                            }
                            else if ((y - 1) >= 0 && step1[x][y - 1] == target)
                            {
                                step1[x][y] = emptyCell;
                                step1[x][y - 1] = hero;
                                New_level();
                                return;
                            }
                        }
                        else if (keyInfo.Key == ConsoleKey.RightArrow)
                        {
                            if ((y + 1) <= (step1[x].Length - 1) && step1[x][y + 1] == emptyCell)
                            {
                                step1[x][y] = emptyCell;
                                step1[x][y + 1] = hero;
                                return;
                            }
                            else if ((y + 1) <= (step1[x].Length - 1) && step1[x][y + 1] == target)
                            {
                                step1[x][y] = emptyCell;
                                step1[x][y + 1] = hero;
                                New_level();
                                return;
                            }
                            else if ((y + 1) <= (step1[x].Length - 1) && step1[x][y + 1] == target1)
                            {
                                step1[x][y] = emptyCell;
                                step1[x][y ] = hero;
                                inf();
                                return;
                            }
                        }
                    }
                }
            }
        }


    }
}
