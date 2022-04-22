using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace textGame
{
    class Help
    {
        public static String[] help = { "inventory - displays a list of items you currently have",
                                        "quit - exits the game" };

        public static void Display()
        {
            foreach (string command in help)
            {
                Console.WriteLine(command);
            }
        }
    }
}
