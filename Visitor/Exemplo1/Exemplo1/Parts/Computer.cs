using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo1.Parts
{
    public class Computer : IComputerParts
    {
        private List<IComputerParts> parts;

        public Computer()
        {
            parts = new List<IComputerParts>()
            {
                new Mouse(), new Monitor(), new Keyboard()
            };
        }

        public void Accept(IVisitor visitor)
        {
            for (int i = 0; i < parts.Count; i++)
                parts[i].Accept(visitor);
             
            visitor.Visit(this);
        }

        public void Execute()
        {
            Console.WriteLine("Executing some Action in Computer");
        }

    }
}
