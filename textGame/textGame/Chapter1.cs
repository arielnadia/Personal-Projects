using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace textGame
{
    class Chapter1
    {
        public static void Display()
        {
            Console.WriteLine("Chapter 1");
            Console.WriteLine("");
            Console.WriteLine("You wake up to the sound of your alarm.  What do you do?");
            bool advance = false;
            int snoozeCount = 0;
            while (!advance)
            {
                string answer = Input.Receive();
                string choice = answer;
                if (answer.Contains("snooze") || answer.Contains("sleep") || answer.Contains("to bed"))
                    choice = "snooze";
                if (answer.Contains("throw") || answer.Contains("break"))
                    choice = "throw";
                if (answer.Contains("wake") || answer.Contains("get up") || answer.Contains("dismiss") || answer.Contains("off"))
                    choice = "wake";
                if (answer.Contains("help"))
                    choice = "help";
                if (answer.Contains("inventory"))
                    choice = "inventory";
                if (answer.Contains("quit"))
                    choice = "quit";
                if (snoozeCount > 9)
                    choice = "sleep in";
                switch (choice)
                {
                    case "snooze":
                        Console.WriteLine("You snooze the alarm.  It goes off again.  What do you do?");
                        snoozeCount++;
                        break;
                    case "sleep in":
                        Console.WriteLine("You snoozed the alarm too many times.  You never woke up.");
                        GameOver.TheEnd();
                        break;
                    case "throw":
                        Console.WriteLine("You throw the alarm.  It hits the wall and breaks.  Well done, idiot.  What now?");
                        break;
                    case "wake":
                        Console.WriteLine("You shut off the alarm and get out of bed.");
                        advance = true;
                        break;
                    case "help":
                        Help.Display();
                        break;
                    case "inventory":
                        Inventory.Display();
                        break;
                    case "quit":
                        GameOver.TheEnd();
                        break;
                    default:
                        Console.WriteLine("Invalid command, try again.");
                        break;
                }
            }
            Console.WriteLine("You look around and notice your door is slightly open.  What do you do?");
            advance = false;
            while (!advance)
            {
                string answer = Input.Receive();
                string choice = answer;
                if (answer.Contains("to bed") || answer.Contains("lie down") || answer.Contains("lay down") || answer.Contains("sleep"))
                    choice = "bed";
                if (answer.Contains("close"))
                    choice = "close";
                if (answer.Contains("open"))
                    choice = "open";
                if (answer.Contains("look"))
                    choice = "look";
                if (answer.Contains("help"))
                    choice = "help";
                if (answer.Contains("inventory"))
                    choice = "inventory";
                if (answer.Contains("quit"))
                    choice = "quit";
                switch(choice)
                {
                    case "bed":
                        Console.WriteLine("You go back to bed.  Apparently you didn't feel like doing anything today...");
                        GameOver.TheEnd();
                        break;
                    case "close":
                        Console.WriteLine("You close the door.  Now what?");
                        break;
                    case "open":
                        Console.WriteLine("You open the door and peak outside...");
                        advance = true;
                        break;
                    case "look":
                        Console.WriteLine("You look around your room.  You see a flashlight on your nightstand.");
                        Inventory.AddItem("flashlight");
                        Console.WriteLine("Item Received: flashlight");
                        break;
                    case "help":
                        Help.Display();
                        break;
                    case "inventory":
                        Inventory.Display();
                        break;
                    case "quit":
                        GameOver.TheEnd();
                        break;
                    default:
                        Console.WriteLine("Invalid command, try again.");
                        break;
                }
            }
        }
    }
}
