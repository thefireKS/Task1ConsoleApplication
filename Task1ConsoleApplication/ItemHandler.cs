using System;
using System.Collections.Generic;

namespace Task1ConsoleApplication
{
    public abstract class ItemHandler
    {
        public List<Item> itemsIn;
        public abstract void AddItem(Item item);
        public abstract void RemoveItem(Item item);

        public virtual void ShowAllItems()
        {
            foreach (var _item in itemsIn)
            {
                Console.WriteLine(_item.name);
            }
        }
    }
}