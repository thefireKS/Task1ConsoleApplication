using System;
using System.Collections.Generic;

namespace Task1ConsoleApplication
{
    public class PlayerInventory : ItemHandler
    {
        public PlayerInventory(List<Item> inventoryItems) 
        {
            inventoryItems = new List<Item>();
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