using System;

namespace Task1ConsoleApplication
{
    public class Amulet : Item
    {
        public override void UseItem()
        {
            Console.WriteLine("Amulet is on your hand now. Shiny!");
        }

        public Amulet(string name, int maxQuantity) : base(name, maxQuantity) { }
    }
}