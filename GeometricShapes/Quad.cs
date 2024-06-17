using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricShapes
{
    internal class Quad
    {
        public int Side1 { get; set; } = 0;
        public int Side2 { get; set; }= 0;
        public int Side3 { get; set; } = 0;
        public int Side4 { get; set; } = 0;

        public int Perimeter()
        {
            return Side1 + Side2 + Side3 + Side4;
        }
        
        public int Area()
        {
            Console.WriteLine("Not implemented");
            return 0;
        }

        public Quad(int side1, int side2, int side3, int side4) 
        {
            this.Side1 = side1;
            this.Side2 = side2;
            this.Side3 = side3;
            this.Side4 = side4;
        }
         

    }
}
