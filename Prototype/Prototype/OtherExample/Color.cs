using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype.OtherExample
{
    public class Color: ColorPrototype
    {
        private int _red;
        private int _green;
        private int _blue;

        // Constructor
        public Color(int red, int green, int blue)
        {
            this._red = red;
            this._green = green;
            this._blue = blue;
        }

        // Create a shallow copy
        public override ColorPrototype Clone()
        {
            Console.WriteLine(
            "Cloning color RGB: {0,3},{1,3},{2,3}",
            _red, _green, _blue);

            return this.MemberwiseClone() as ColorPrototype;
        }

        public override void SetGreen(int green)
        {
            this._green = green;
        }

        public override string ToString()
        {
            return $"{_red} - {_green} - {_blue}";
        }

    }
}
