using System;
using System.Collections.Generic;

namespace Task1ConsoleApplication
{
    public class PlayerInventory : ItemHandler
    {
        public override List<Item> itemsIn { get; set; }
        public PlayerInventory() 
        {
            itemsIn = new List<Item>();
        }

        public PlayerInventory(List<Item> items)
        {
            itemsIn = items;
        }

        public override void AddItem(Item item)
        {
            itemsIn.Add(item);
        }

        public override void RemoveItem(Item item)
        {
            itemsIn.Remove(item);
        }
    }
}