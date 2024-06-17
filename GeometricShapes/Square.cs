using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricShapes
{
    internal class Square
    {
        public int Side1 { get; set; } = 0;

        public int Perimeter()
        {
            return Side1*4;
        }
        public int Area()
        {
            return Side1 * Side1;

        }
        public Square(int side1)
        {
            Side1 = side1;
        }
    }
}
