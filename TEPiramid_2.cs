using System;
using System.Collections.Generic;
using System.Text;

namespace Laba1_Var4_2_
{
    class TEPiramid : TETriangle
    {
        public double height;

        public TEPiramid(double side, double hightLength) : base(side)
        {
            height = hightLength;
        }
        public double Volume()
        {
            return (Area() * height) / 3 ;
        }
        public new double Area()
        {
            double lateralArea = (3 * side * height) / 2;
            return base.Area() + lateralArea;
        }
    }
}
