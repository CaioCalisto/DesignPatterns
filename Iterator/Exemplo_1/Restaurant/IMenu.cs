
namespace Exemplo_1.Restaurant
{
    public interface IMenu
    {
        void AddItem(string name, string description, bool isvegetarian, double price);
        void Remove(string name);
        IIterator CreateIterator();
    }
}
