using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype
{
    public class Concrete1 : Prototype
    {
        public Concrete1(string id)
            : base(id)
        { }

        public override Prototype Clone()
        {
            return (Prototype)this.MemberwiseClone();
        }

    }
}
