using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace textGame
{
    class Input
    {
        public static string Receive()
        {
            string answer = Console.ReadLine().ToLower();
            return answer;
        }
    }
}
