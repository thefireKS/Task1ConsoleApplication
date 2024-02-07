using System;

namespace Task1ConsoleApplication
{
    public class Amulet : Item
    {
        public override string name { get; set; }
        public override int currentQuantity { get; set; }
        protected override int maxQuantity { get; set; }

        public override void UseItem()
        {
            Console.WriteLine("Amulet is on your hand now. Shiny!");
        }

        public Amulet(string name, int maxQuantity) : base(name, maxQuantity) { }
    }
}