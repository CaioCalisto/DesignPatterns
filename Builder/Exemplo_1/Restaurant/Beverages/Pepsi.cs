using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_1.Restaurant.Beverages
{
    public class Pepsi : ColdDrink
    {
        public override double GetPrice()
        {
            return 1.65;
        }

        public override string GetName()
        {
            return "Pepsi Cola";
        }
    }
}
