using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype.OtherExample
{
    public abstract class ColorPrototype
    {
        public abstract ColorPrototype Clone();
        public abstract void SetGreen(int green);
    }
}
