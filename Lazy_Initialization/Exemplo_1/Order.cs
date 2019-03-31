
namespace Exemplo_1
{
    public class Order
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

        public Order(string name, double price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }

    }
}
