using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_1.Ducks
{
    public class Counter: Ducks.IDuck
    {
        private Ducks.IDuck duck;
        static int count;

        public Counter(Ducks.IDuck duck)
        {
            this.duck = duck;
        }

        public void Quack()
        {
            count++;
            duck.Quack();
        }

        public static int GetCounter()
        {
            return count;
        }

    }
}
