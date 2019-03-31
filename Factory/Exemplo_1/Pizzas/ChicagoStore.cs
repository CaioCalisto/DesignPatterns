using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_1.Pizzas
{
    public class ChicagoStore : Store
    {
        protected override IPizza CreatePizza(string flavor)
        {
            IPizza pizza = null;
            if (flavor.ToUpper() == "CHEESE")
                pizza = new Pizzas.Chicago.Cheese();
            else if (flavor.ToUpper() == "PEPPERONI")
                pizza = new Pizzas.Chicago.Pepperoni();
            else if (flavor.ToUpper() == "VEGGIE")
                pizza = new Pizzas.Chicago.Veggie();

            return pizza;
        }
    }
}
