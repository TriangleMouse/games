using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace games
{
    public class RAndom:Variant
    {

        public static void random()
        {
            Random rand = new Random();
            int n = rand.Next(1, 11);
            if (n == 1){history1();}
            if (n == 2){history2();}
            if (n == 3){history3();}
            if (n == 4){history4();}
            if (n == 5){history5();}
            if (n == 6){history6();}
            if (n == 7){history7();}
            if (n == 8){history8();}
            if (n == 9){history9();}
            if (n == 10){history10();}
            if (n == 11){history11();}

        }

    }
}
