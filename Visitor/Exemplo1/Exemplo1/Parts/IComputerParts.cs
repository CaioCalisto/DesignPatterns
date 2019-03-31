using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo1.Parts
{
    public interface IComputerParts
    {
        void Accept(IVisitor visitor);
        void Execute();
    }
}
