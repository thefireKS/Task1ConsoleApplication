using System;

namespace Task1ConsoleApplication
{
    public class Coin : Item
    {
        public override void UseItem()
        {
            Console.WriteLine("Coin throwed!");
        }

        public Coin(string name, int maxQuantity) : base(name, maxQuantity)
        {
            currentQuantity = base.maxQuantity;
        }

        public Coin(string name, int currentQuantity, int maxQuantity) : base(name, currentQuantity, maxQuantity) { }
    }
}