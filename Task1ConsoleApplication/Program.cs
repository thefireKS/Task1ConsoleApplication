using Task1ConsoleApplication.Properties;

namespace Task1ConsoleApplication
{
    internal class Program
    {
        public Amulet shadowAmulet = new Amulet("Amulet of the great shadows", 1);
        public Coin coins = new Coin("Bag of coins", 33, 100);
        public Book boringBook = new Book("Boring as hell book", 1);

        public PlayerInventory _playerInventory;
        public Table _table;
        public static void Main(string[] args)
        {
        }
    }
}