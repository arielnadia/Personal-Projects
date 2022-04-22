using System;
using System.Collections.Generic;
using System.Text;

namespace textGame
{
    class Chapter2
    {
        public static void Display()
        {
            Console.WriteLine("Chapter 2");
            Console.WriteLine("");
            Console.WriteLine("You look outside your room, but it's dark.  What do you do?");
            bool advance = false;
            while (!advance)
            {
                string answer = Input.Receive();
                string choice = answer;
                if (answer.Contains("flashlight") && Inventory.Contains("flashlight"))
                    choice = "use flashlight";
                if (answer.Contains("bed") || answer.Contains("sleep"))
                    choice = "sleep";
                if (answer.Contains("cry"))
                    choice = "cry";
                if (answer.Contains("close"))
                    choice = "close";
                if (answer.Contains("look") && !(Inventory.Contains("flashlight")))
                    choice = "look around";
                if (answer.Contains("help"))
                    choice = "help";
                if (answer.Contains("inventory"))
                    choice = "inventory";
                if (answer.Contains("quit"))
                    choice = "quit";
                switch(choice)
                {
                    case "use flashlight":
                        Console.WriteLine("You use the flashlight you found.  Now you can see outside your room.");
                        advance = true;
                        break;
                    case "sleep":
                        Console.WriteLine("You go back to bed.  Apparently you didn't feel like doing anything today...");
                        GameOver.TheEnd();
                        break;
                    case "cry":
                        Console.WriteLine("You break down crying in the doorway.  You're afraid of the dark.");
                        GameOver.TheEnd();
                        break;
                    case "close":
                        Console.WriteLine("You close the door.  What now?");
                        break;
                    case "look around":
                        Console.WriteLine("You look around around your room.  You see a flashlight on your nightstand.");
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
            Console.WriteLine("You look outside your room and see your sister down the hallway.  She waves at you and motions you over.  What do you do?");
            advance = false;
            int hitCount = 0;
            while (!advance)
            {
                string answer = Input.Receive();
                string choice = answer;
                if (answer.Contains("hi") || answer.Contains("hello") || answer.Contains("wave") || answer.Contains("greet"))
                    choice = "greet";
                if (answer.Contains("slap") || answer.Contains("punch") || answer.Contains("kick") || answer.Contains("hit"))
                    choice = "hit";
                if (answer.Contains("bed") || answer.Contains("inside") || answer.Contains("go back"))
                    choice = "go back";
                if (answer.Contains("help"))
                    choice = "help";
                if (answer.Contains("inventory"))
                    choice = "inventory";
                if (answer.Contains("quit"))
                    choice = "quit";
                if (hitCount > 2)
                    choice = "rude";
                switch (choice)
                {
                    case "greet":
                        Console.WriteLine("You walk up to your sister and say hello.");
                        advance = true;
                        break;
                    case "hit":
                        Console.WriteLine("Really?  You hit your sister.  What an ass.  Are you going to do anything more productive?");
                        hitCount++;
                        break;
                    case "go back":
                        Console.WriteLine("You ignore your sister, returning to your room and going back to bed.  Apparently you didn't feel like doing anything today...");
                        GameOver.TheEnd();
                        break;
                    case "rude":
                        Console.WriteLine("You try to hit your sister again, but she blocks your attack and delivers a swift blow to the side of your head, knocking you unconscious.  Maybe next time you won't be so rude.");
                        GameOver.TheEnd();
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
