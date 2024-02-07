namespace Task1ConsoleApplication
{
    public abstract class Item
    {
        public abstract string name { get; set; }
        public abstract int currentQuantity { get; set; }
        protected abstract int maxQuantity { get; set; }

        protected Item(string _name, int _currentQuantity, int _maxQuantity)
        {
            name = _name;
            currentQuantity = _currentQuantity;
            maxQuantity = _maxQuantity;
        }

        protected Item(string _name, int _maxQuantity)
        {
            name = _name;
            maxQuantity = _maxQuantity;
            currentQuantity = maxQuantity;
        }

        public abstract void UseItem();
    }
}