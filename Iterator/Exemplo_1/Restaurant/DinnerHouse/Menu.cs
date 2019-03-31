using System;
using System.Collections.Generic;

namespace Exemplo_1.Restaurant.DinnerHouse
{
    public class Menu : IMenu
    {
        private List<Item> items;

        public Menu()
        {
            items = new List<Item>()
            {
                new Item("Hotdog", "A hotdog with saurkraut, relish, onion, topped with cheese", false, 3.5),
                new Item("Vegetarian BLT", "Baccon with lettuce", true, 2.99)
            };
        }

        public void AddItem(string name, string description, bool isvegetarian, double price)
        {
            items.Add(new Item(name, description, isvegetarian, price));
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
