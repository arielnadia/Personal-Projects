using System;
using System.Collections.Generic;
using System.Text;

namespace textGame
{
    class GameOver
    {
        public static void TheEnd()
        {
            Console.WriteLine("Game Over.");
            Console.WriteLine("Thanks for playing!");
            Environment.Exit(0);
        }
    }
}
