using System;

namespace Exemplo_1.Restaurant.PancakeHouse
{
    public class Menu : IMenu
    {
        private int maxitems = 5;
        private Item[] items;
        private int position;

        public Menu()
        {
            items = new Item[maxitems];
            items[0] = new Item("Regular breakfast", "Pancake with eggs, sausage", true, 2.99);
            items[1] = new Item("K&B breakfast", "Pancake with toast and meat", true, 2.99);
            position = 2;
        }

        public void AddItem(string name, string description, bool isvegetarian, double price)
        {
            if (position < maxitems - 1)
            {
                items[position] = new Item(name, description, isvegetarian, price);
                position++;
            }            
        }

        public void Remove(string name)
        {
            throw new InvalidOperationException();
        }

        public IIterator CreateIterator()
        {
            return new MenuIterator(items);
        }

    }
}
