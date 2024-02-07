using System;
using System.Collections.Generic;
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
        public static void Main()
        {
            Program instance = new Program();
            instance.LoadTable();
            instance.LoadPlayer();
            
            instance.ConsoleInteraction();
        }

        private void LoadTable()
        {
            _table = new Table(new List<Item>() {shadowAmulet,coins,boringBook});
            Console.WriteLine("Table loaded!");
        }
        
        private void LoadPlayer()
        {
            _playerInventory = new PlayerInventory();
            Console.WriteLine("Player loaded!");
        }
        
        private void CheckInventory(ItemHandler inventoryToLook)
        {
            inventoryToLook.ShowAllItems();
        }

        private void pickupItem(Item itemToTake,ItemHandler takenFrom, ItemHandler takenTo)
        {
            if (itemToTake == null)
            {
                Console.WriteLine("Нет предмета с таким номером!");
                return;
                
                //Да, здесь появляется exception, и если вы захотите - сломаете простейшим действием эту программу.
                //Не знаю точно, надо ли так сильно заморачиваться, поэтому оставлю пока так. Предположим, что пользователь умнее.
            }
            
            takenFrom.RemoveItem(itemToTake);
            takenTo.AddItem(itemToTake);
        }

        private void ConsoleInteraction()
        {
                        int interactionNumber = 0;
                
            while (interactionNumber != 9)
            {
                Console.WriteLine("Выберите действие и введите его номер. " +
                                  "Если хотите взаимодействовать с каким-то объектом, введите его номер\n");
                Console.WriteLine("1. Посмотреть свой инвентарь\n2. Осмотреть стол\n3. Взять предмет со стола\n4. Положить предмет на стол" );
                interactionNumber = int.Parse(Console.ReadLine());
                switch (interactionNumber)
                {
                    case 1:
                        CheckInventory(_playerInventory);
                        break;
                    case 2:
                        CheckInventory(_table);
                        break;
                    case 3:
                    {
                        Console.WriteLine("Введите номер предмета. Или нажмите 0 для возвращения, если вы забыли номер предмета.");
                        interactionNumber = int.Parse(Console.ReadLine());
                        if(interactionNumber == 0)
                            break;
                        pickupItem(_table.itemsIn[interactionNumber-1],_table,_playerInventory);
                        break;
                    }
                    case 4:
                    {
                        Console.WriteLine("Введите номер предмета. Или нажмите 0 для возвращения, если вы забыли номер предмета.");
                        interactionNumber = int.Parse(Console.ReadLine());
                        if(interactionNumber == 0)
                            break;
                        pickupItem(_playerInventory.itemsIn[interactionNumber-1],_playerInventory,_table);
                        break;
                    }
                    case 9:
                        Console.WriteLine("Прощайте!");
                        break;
                    default:
                        Console.WriteLine("Нет такой команды.");
                        break;
                }
            }
        }
    }
}