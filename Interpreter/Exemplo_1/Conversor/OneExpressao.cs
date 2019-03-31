using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_1.Conversor
{
    public class OneExpressao : Expressao
    {
        public override String One()
        {
            return "I";
        }

        public override String Four()
        {
            return "IV";
        }

        public override String Five()
        {
            return "V";
        }

        public override String Nine()
        {
            return "IX";
        }

        public override int Multiplier()
        {
            return 1;
        }
    }
}
