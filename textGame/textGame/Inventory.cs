using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace textGame
{
    class Inventory
    {
        public static List<string> inventory = new List<string>();

        public static void Display()
        {
            Console.WriteLine("Here is what you have right now: ");
            if (inventory.Count == 0)
                Console.WriteLine("Your inventory is empty.");
            else
            {
                foreach (string item in inventory)
                {
                    Console.WriteLine(item);
                }
            }
        }

        public static bool Contains(string item)
        {
            bool haveItem = inventory.Contains(item);
            return haveItem;
        }
        
        public static void AddItem(string item)
        {
            inventory.Add(item);
        }

        public static void RemoveItem(string item)
        {
            inventory.Remove(item);
        }
    }
}
