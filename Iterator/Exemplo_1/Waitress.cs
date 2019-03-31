using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_1
{
    public class Waitress
    {
        private Restaurant.IMenu[] menus;

        public Waitress(Restaurant.IMenu[] menus)
        {
            this.menus = menus;
        }

        public void PrintMenu()
        {
            foreach(Restaurant.IMenu  menu in menus)
            {
                Restaurant.IIterator iterator = menu.CreateIterator();
                PrintMenu(iterator);
            }
        }

        private void PrintMenu(Restaurant.IIterator iterator)
        {
            while(iterator.HasNext())
            {
                Restaurant.Item item = (Restaurant.Item)iterator.Next(); 
                Console.WriteLine(item);
            }
        }

    }
}
