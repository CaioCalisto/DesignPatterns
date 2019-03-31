using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_1.Conversor
{
    public class HundredExpressao : Expressao
    {
        public override String One()
        {
            return "C";
        }

        public override String Four()
        {
            return "CD";
        }

        public override String Five()
        {
            return "D";
        }

        public override String Nine()
        {
            return "CM";
        }

        public override int Multiplier()
        {
            return 100;
        }
    }
}
