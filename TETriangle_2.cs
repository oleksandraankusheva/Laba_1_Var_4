using System;

namespace Laba1_Var4_2_
{
    class TETriangle
    {
        public double side;

        public TETriangle()
        {
            side = 0;
        }

        public TETriangle(double length)
        {
            side = length;
        }

        public TETriangle(TETriangle newTriangle)
        {
            side = newTriangle.side;
        }

        public override string ToString()
        {
            return $"Рiвностороннiй трикутник зi стороною {side}.";
        }

        public double Area()
        {
            return Math.Pow(side, 2) * (Math.Sqrt(3) / 4);
;       }

        public double Perimeter()
        {
            return 3 * side;
        }

        public bool Equals(TETriangle otherTriangle)
        {
            return this.side == otherTriangle.side;
        }

        public static TETriangle operator *(TETriangle triangle, double multiplier)
        {
            return new TETriangle(triangle.side * multiplier);
        }

        // Перевантаження оператору множення * (трикутник*число)
        public static TETriangle operator *(double multiplier, TETriangle triangle)
        {
            return triangle * multiplier;
        }
    }
}
