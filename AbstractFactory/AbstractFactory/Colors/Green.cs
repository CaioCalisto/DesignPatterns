using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Colors
{
    public class Green : IColor
    {
        public void Fill()
        {
            Console.WriteLine("Inside Green::fill() method.");
        }
    }
}
