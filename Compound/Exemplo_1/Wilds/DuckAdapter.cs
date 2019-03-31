using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_1.Wilds
{
    public class DuckAdapter : Ducks.IDuck
    {
        private IWild wild;

        public DuckAdapter(IWild wild)
        {
            this.wild = wild;
        }

        public void Quack()
        {
            wild.Honk();
        }
    }
}
