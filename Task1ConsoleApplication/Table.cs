namespace Task1ConsoleApplication
{
    public class Table : ItemHandler
    {
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