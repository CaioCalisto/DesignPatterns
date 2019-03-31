using System;
using System.Collections.Generic;
using System.Text;
using AbstractFactory.Colors;
using AbstractFactory.Shapes;

namespace AbstractFactory
{
    public class ColorFactory : AbstractFactory
    {
        public override IColor GetColor(string color)
        {
            switch(color.ToUpper())
            {
                case "RED":
                    return new Colors.Red();
                case "GREEN":
                    return new Colors.Green();
                case "BLUE":
                    return new Colors.Blue();
                default:
                    return null;
            }
        }

        public override IShape GetShape(string shape)
        {
            return null;
        }
    }
}
