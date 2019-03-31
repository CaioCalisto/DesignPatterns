using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_1.Components.Beverages
{
    public class Chocolate : Beverage
    {
        private Size size;

        public Chocolate(Size size)
        {
            this.Description = "Chocolate";
            this.size = size;
        }

        public override Size GetSize()
        {
            return size;
        }
         
        public override double Cost()
        {
            return 2.3;
        }

    }
}
