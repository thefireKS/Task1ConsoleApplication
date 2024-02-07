using System;

namespace Task1ConsoleApplication.Properties
{
    public class Book : Item
    {
        public override string name { get; set; }
        public override int currentQuantity { get; set; }
        protected override int maxQuantity { get; set; }

        public override void UseItem()
        {
            Console.WriteLine("You read a book for a while. Boring");
        }

        public Book(string name, int maxQuantity) : base(name, maxQuantity) { }
    }
}