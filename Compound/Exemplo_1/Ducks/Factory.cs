using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_1.Ducks
{
    public class Factory : DuckFactory
    {
        public override IDuck CreateMallard()
        {
            return new Mallard();
        }

        public override IDuck CreateRedHead()
        {
            return new RedHead();
        }

        public override IDuck CreateRubber()
        {
            return new Rubber();
        }
    }
}
