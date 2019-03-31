using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_1
{
    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        private Lazy<List<Order>> orders;

        public List<Order> Orders
        {
            get 
            {                
                return orders.Value;
            }
        }

        public Customer(int id, string name)
        {
            ID = id;
            Name = name;
        }

        public void LoadOrders()
        {
            if (orders == null)
            {
                orders = new Lazy<List<Order>>();
                orders.Value.Add(new Order("PC", 400, 1));
                orders.Value.Add(new Order("Mouse", 20, 1));
            }
        }

    }
}
