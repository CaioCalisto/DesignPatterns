using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_1.Restaurant.Packs
{
    public class Wrapper : Packing
    {
        public override string Pack()
        {
            return "Packing";
        }
    }
}
