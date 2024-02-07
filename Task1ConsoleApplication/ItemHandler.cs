using System;
using System.Collections.Generic;

namespace Task1ConsoleApplication
{
    public abstract class ItemHandler
    {
        public abstract List<Item> itemsIn { get; set; }
        public abstract void AddItem(Item item);
        public abstract void RemoveItem(Item item);

        public virtual void ShowAllItems()
        {
            if (itemsIn.Count == 0)
            {
                Console.WriteLine("Пусто.");
                return;
            }
            for(int i = 0; i<itemsIn.Count; i++)
            {
                Console.WriteLine($"{i+1}. {itemsIn[i].name}: {itemsIn[i].currentQuantity} шт.");
            }
        }
    }
}