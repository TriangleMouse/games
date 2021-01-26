using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace games
{
    public class MENU : STep71
    {
        public static void menu()
        {

            Console.WriteLine("1-Новая игра");
            Console.WriteLine("2-Выход");
            var keyInfo = Console.ReadKey();
            move(keyInfo);
        }
        public static void move(ConsoleKeyInfo keyInfo)
        {

            if (keyInfo.Key == ConsoleKey.D1)
            {
                Step71();
            }
            if (keyInfo.Key == ConsoleKey.D2)
            {
                Environment.Exit(0);
            }
        }
    }
}
