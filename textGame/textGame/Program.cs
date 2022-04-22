using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace textGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the game!");
            Console.WriteLine("This is a text-based adventure, where you will read each scenario and respond by typing a command.");
            Console.WriteLine("You can type 'help' at any time to view a list of universal commands.  These are not contextual to the game's scenarios - You must figure those out yourself!");
            Console.WriteLine("");
            
            Chapter1.Display();
            Console.WriteLine("");
            Chapter2.Display();
        }
    }
}
