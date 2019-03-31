using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_1.Restaurant.Sanduich
{
    public class Cheese : Burguer
    {
        public override double GetPrice()
        {
            return 6.99;
        }

        public override string GetName()
        {
            return "Cheese Burger";
        }

    }
}
