using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Colors
{
    public class Red : IColor
    {
        public void Fill()
        {
            Console.WriteLine("Inside Red::fill() method.");
        }
    }
}
