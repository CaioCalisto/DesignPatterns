using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_1.Restaurant
{
    public abstract class Item
    {
        public abstract string GetName();
        public abstract Packing GetPack();
        public abstract double GetPrice();
    }
}
