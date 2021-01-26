using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace games
{

    public class End :End2
    {
        public static void END()
        {
            Console.WriteLine("Вы наконец-то вышли из этого ужаса  живым.");
            Thread.Sleep(2000);
            Console.WriteLine("Вы были счастливым ,потому что смогли уйти от туда и одновременно потеряным,так как не знали что делать дальше ,и как жить дальше...");
            Thread.Sleep(4000);
            Console.Clear();
            Console.WriteLine("......................The END.........................");
            Thread.Sleep(5000);
            Environment.Exit(0);
        }

        public static void vozvrat()
        {
            Console.WriteLine("Вам обратно не нужно,не забывайте ,что ваша цель сбежать.");
            Thread.Sleep(3000);
        }
    }
}
