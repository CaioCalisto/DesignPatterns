using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_1.Conversor
{
    public class ThousandExpressao : Expressao
    {
        public override String One() 
        { 
            return "M";
        }

        public override String Four() 
        { 
            return " "; 
        }

        public override String Five() 
        { 
            return " "; 
        }

        public override String Nine() 
        { 
            return " "; 
        }

        public override int Multiplier() 
        { 
            return 1000; 
        }

    }
}
