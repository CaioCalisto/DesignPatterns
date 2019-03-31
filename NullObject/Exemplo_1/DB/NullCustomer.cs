using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_1.DB
{
    public class NullCustomer : Customer
    {
        public override string GetName()
        {
            return "Not Available in Customer Database";
        }

        public override bool Isnull()
        {
            return true;
        }

    }
}
