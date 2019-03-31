using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class FactoryProducer
    {
        public static AbstractFactory GetFactory(string choice)
        {
            switch(choice.ToUpper())
            {
                case "SHAPE":
                    return new ShapeFactory();
                case "COLOR":
                    return new ColorFactory();
                default:
                    return null;
            }
        }
    }
}
