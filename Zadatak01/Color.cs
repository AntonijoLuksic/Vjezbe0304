using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak01
{
     class Color
    {
        private readonly int red;
        private readonly int green;
        private readonly int blue;

        public Color(int red, int green, int blue)
        {
            if (red<0 || red>255 || green<0 || green>255 || blue<0 || blue>255)
            {
                throw new Exception("Color values must be in range [0-255]");
            }
            this.red = red;
            this.green = green;
            this.blue = blue;
        }

        public override string ToString() => $"C({red}, {green}, {blue})";
        
    }
}
