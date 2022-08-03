using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak01
{
    class Point
    {
        private int x;
        private int y;

        public int X
        {
            get
            {
                return this.x;
            }
            set
            {
                if (value<0||value>100)
                {
                    throw new Exception("Coordinate must be in range [0-100]");
                }
                this.x = value;
            }
        }

        public int Y
        {
            get
            {
                return this.y;
            }
            set
            {
                if (value < 0 || value > 100)
                {
                    throw new Exception("Coordinate must be in range [0-100]");
                }
                y= value;
            }
        }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public override string ToString()
        {
            return $"P({X}, {Y})";
        }
    }
}
