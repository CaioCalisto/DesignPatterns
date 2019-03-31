using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_1.Wilds
{
    public class Goose : IWild
    {
        public void Honk()
        {
            Console.WriteLine("HONK");
        }
    }
}
