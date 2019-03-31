using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_1.Ducks
{
    public abstract class DuckFactory
    {
        public abstract IDuck CreateMallard();
        public abstract IDuck CreateRedHead();
        public abstract IDuck CreateRubber();
    }
}
