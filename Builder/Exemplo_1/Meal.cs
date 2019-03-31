using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exemplo_1.Restaurant;

namespace Exemplo_1
{
    public class Meal
    {
        private List<Item> items;

        public Meal()
        {
            items = new List<Item>();
        }

        public void Add(Item item)
        {
            items.Add(item);
        }

        public double GetCost()
        {
            double cost = 0;
            foreach (Item item in items)
                cost += item.GetPrice();

            return cost;
        }

        public void ShowItems()
        {
            foreach(Item item in items)
                Console.WriteLine(string.Format("Name: {0}, Pack: {1} , R$ {2}", item.GetName(), item.GetPack().Pack(), item.GetPrice()));
        }


    }
}
