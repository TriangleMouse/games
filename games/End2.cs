using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace games
{
    public class End2 
    {
        public static List<string[]> step1 = new List<string[]>();
        public static bool gameStatus = true; //Статус игры
        public static string hero = "X"; //Герой
        public static string wall = "#"; //Стена
        public static string target = "1"; //Цель
        public static string target1 = "V"; //Цель
        public static string emptyCell = " "; //Пустая ячейка
        public static void Stepend()
        {
            Console.WindowTop = 1366;
            step1.Add(new string[] { "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#" });
            step1.Add(new string[] { "#", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "#", "#", "#", "#", "#", "#", "#", "#", "#" });
            step1.Add(new string[] { "#", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "#", "#", "#", "#", "#", "#", "#", "#", "#" });
            step1.Add(new string[] { "#", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "#", "#", "#", "#", "#", "#", "#", "#", "#" });
            step1.Add(new string[] { "#", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "#", " ", " ", " ", "#", " ", "#", " ", "#" });
            step1.Add(new string[] { "#", "#", "X", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "#", " ", "#", " ", "#", " ", " ", " ", "#" });
            step1.Add(new string[] { "#", "1", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "#", " ", "#", " ", "#", " ", "#" });
            step1.Add(new string[] { "#", "#", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "#", " ", " ", " ", "#", "V", "#" });
            step1.Add(new string[] { "#", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "#", " ", "#", "#", "#", " ", "#", "#", "#" });
            step1.Add(new string[] { "#", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "#", " ", "#", " ", "#", " ", "#", "#", "#" });
            step1.Add(new string[] { "#", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "#", " ", " ", " ", "#", " ", " ", " ", "#" });
            step1.Add(new string[] { "#", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "#", " ", " ", " ", " ", "#", "#", " ", "#" });
            step1.Add(new string[] { "#", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "#", "#", "#", "#", "#", "#", "#", " ", "#" });
            step1.Add(new string[] { "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#" });
            render();
            while (gameStatus)
            {
                var keyInfo = Console.ReadKey();
                moveHero(keyInfo);
                render();
            }
        }

        public static void exit()
        {
            Console.Clear();
            Console.WriteLine("Вы сели в спасательную капсулу и отправились на свою планету.");
            Thread.Sleep(3000);
            Console.Clear();
            Console.WriteLine("Вы спаслись,поздравляем.");
            Thread.Sleep(3000);
            Environment.Exit(0);
        }
        public static void obratno()
        {
            Console.WriteLine("Мне обратно не нужно,здесь  имеются капсулы спасательные и я могу убежать");
            Thread.Sleep(3000);

        }
        public static void render()
        {
            Console.Clear();
            for (int x = 0; x < step1.Count; x++)
            {
                Console.WriteLine(string.Join("", step1[x]));
            }
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
                       
                        }
                        else if (keyInfo.Key == ConsoleKey.DownArrow)
                        {
                            if ((x + 1) <= (step1.Count - 1) && step1[x + 1][y] == emptyCell)
                            {
                                step1[x][y] = emptyCell;
                                step1[x + 1][y] = hero;
                                return;
                            }
                            else if ((x + 1) <= (step1.Count - 1) && step1[x + 1][y] == target1)
                            {
                                step1[x][y] = emptyCell;
                                step1[x ][y] = hero;
                                exit();
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
                                obratno();
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
                            
                        }
                    }
                }
            }
        }
    }
}
