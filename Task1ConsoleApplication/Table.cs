using System;
using System.Collections.Generic;

namespace Task1ConsoleApplication
{
    public class Table : ItemHandler
    {
        public override List<Item> itemsIn { get; set; }
        public Table()
        {
            itemsIn = new List<Item>();
        }
        
        public Table(List<Item> items)
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