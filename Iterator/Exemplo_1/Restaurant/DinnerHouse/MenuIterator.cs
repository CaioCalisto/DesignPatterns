using System.Collections.Generic;

namespace Exemplo_1.Restaurant.DinnerHouse
{
    public class MenuIterator : IIterator
    {
        private List<Item> items;
        private int position = 0;

        public MenuIterator(List<Item> items)
        {
            this.items = items;
        }

        public bool HasNext()
        {
            if (position >= items.Count || items[position] == null)
                return false;
            else
                return true;
        }

        public object Next()
        {
            Item item = items[position];
            position++;
            return item;
        }
    }
}
