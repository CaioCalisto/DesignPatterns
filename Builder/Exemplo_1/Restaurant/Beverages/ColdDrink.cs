using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_1.Restaurant.Beverages
{
    public abstract class ColdDrink : Item
    {
        public override Packing GetPack()
        {
            return new Packs.Bottle();
        }

    }
}
