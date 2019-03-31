using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype
{
    public class Concrete2 : Prototype
    {
        public Concrete2(string id)
            : base(id)
        { }

        public override Prototype Clone()
        {
            return (Prototype)this.MemberwiseClone();
        }

    }
}
