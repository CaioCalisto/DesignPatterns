using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_1.Ducks
{
    public class CountQuackFactory : DuckFactory
    {
        public override IDuck CreateMallard()
        {
            return new Counter(new Mallard());
        }

        public override IDuck CreateRedHead()
        {
            return new Counter(new RedHead());
        }

        public override IDuck CreateRubber()
        {
            return new Counter(new Rubber());
        }
    }
}
