namespace Task1ConsoleApplication
{
    public abstract class Item
    {
        public string name;
        protected int currentQuantity;
        protected int maxQuantity;

        protected Item(string name, int currentQuantity, int maxQuantity) { }

        protected Item(string name, int maxQuantity)
        {
            currentQuantity = maxQuantity;
        }

        public abstract void UseItem();
    }
}