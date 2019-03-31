using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public abstract class AbstractFactory
    {
        public abstract Colors.IColor GetColor(string color);
        public abstract Shapes.IShape GetShape(string shape);
    }
}
