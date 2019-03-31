using System;
using System.Collections.Generic;
using System.Text;
using AbstractFactory.Colors;
using AbstractFactory.Shapes;

namespace AbstractFactory
{
    public class ShapeFactory : AbstractFactory
    {
        public override IColor GetColor(string color)
        {
            return null;
        }

        public override IShape GetShape(string shape)
        { 
            switch(shape.ToUpper())
            {
                case "CIRCLE":
                    return new Shapes.Circle();
                case "RECTANGLE":
                    return new Shapes.Rectangle();
                case "SQUARE":
                    return new Shapes.Square();
                default:
                    return null;
            } 
        }
    }
}
