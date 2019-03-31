using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_1.Ducks
{
    public class Rubber : IDuck
    {
        public void Quack()
        {
            Console.WriteLine("QUACK");
        }
    }
}
