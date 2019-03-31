using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_1.Pizzas
{
    public abstract class Store
    {
        public void OrderPizza(string flavor)
        {
            IPizza pizza;
            pizza = CreatePizza(flavor);

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();
        }

        protected abstract IPizza CreatePizza(string flavor);


    }
}
