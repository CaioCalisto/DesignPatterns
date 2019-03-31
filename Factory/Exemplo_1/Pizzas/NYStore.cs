using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_1.Pizzas
{
    public class NYStore : Store
    {
        protected override IPizza CreatePizza(string flavor)
        {
            IPizza pizza = null;
            if (flavor.ToUpper() == "CHEESE")
                pizza = new Pizzas.NY.Cheese();
            else if (flavor.ToUpper() == "PEPPERONI")
                pizza = new Pizzas.NY.Pepperoni();
            else if (flavor.ToUpper() == "VEGGIE")
                pizza = new Pizzas.NY.Veggie();

            return pizza;
        }
    }
}
