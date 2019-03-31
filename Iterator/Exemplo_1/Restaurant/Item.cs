
namespace Exemplo_1.Restaurant
{
    public class Item
    {
        public string Name { get; private set; }
        public string Description { get; private set; }
        public bool IsVegetarian { get; private set; }
        public double Price { get; private set; }

        public Item(string name, string description, bool isvegetarian, double price)
        {
            Name = name;
            Description = description;
            IsVegetarian = isvegetarian;
            Price = price;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Description: {Description}, Is Vegetarian: {IsVegetarian}, Price: {Price}";
        }

    }
}
