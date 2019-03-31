using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_1.Conversor
{
    public class TenExpressao : Expressao
    {
        public override String One()
        {
            return "X";
        }

        public override String Four()
        {
            return "XL";
        }

        public override String Five()
        {
            return "L";
        }

        public override String Nine()
        {
            return "XC";
        }

        public override int Multiplier()
        {
            return 10;
        }
    }
}
