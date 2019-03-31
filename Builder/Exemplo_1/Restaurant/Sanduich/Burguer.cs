using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_1.Restaurant.Sanduich
{
    public abstract class Burguer : Item
    {
        public override Packing GetPack()
        {
            return new Packs.Wrapper();
        }

    }
}
