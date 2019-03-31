
namespace Exemplo_1.Restaurant.PancakeHouse
{
    public class MenuIterator : IIterator
    {
        Item[] items;
        private int position = 0;

        public MenuIterator(Item[] items)
        {
            this.items = items;
        }

        public bool HasNext()
        {
            if (position >= items.Length || items[position] == null)
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
