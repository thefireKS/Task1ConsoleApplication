using System;

namespace Task1ConsoleApplication
{
    public class Coin : Item
    {
        public override string name { get; set; }
        public override int currentQuantity { get; set; }
        protected override int maxQuantity { get; set; }

        public override void UseItem()
        {
            Console.WriteLine("Coin throwed!");
        }

        public Coin(string name, int maxQuantity) : base(name, maxQuantity)
        {
            currentQuantity = maxQuantity;
        }

        public Coin(string name, int currentQuantity, int maxQuantity) : base(name, currentQuantity, maxQuantity) { }
    }
}