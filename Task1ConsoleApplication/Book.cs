using System;

namespace Task1ConsoleApplication.Properties
{
    public class Book : Item
    {
        public override void UseItem()
        {
            Console.WriteLine("You read a book for a while. Boring");
        }

        public Book(string name, int maxQuantity) : base(name, maxQuantity) { }
    }
}