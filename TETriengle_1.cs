using System;
using System.Collections.Generic;
using System.Text;

namespace Laba1_4
{
    public class TTriangle
    {
        protected double[] side = new double[3];

        public bool EcsistTriangle(double a, double b, double c)
        {
            if ((a + b > c ^ a + c > b ^ c + b > a) && (a > 0 ^ b > 0 ^ c > 0))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public TTriangle(double a, double b, double c)
        {
            if (!EcsistTriangle(a, b, c))
            {
                Console.WriteLine("Сторони заданi неправильно.");
            }
            else
            {
                side[0] = a;
                side[1] = b;
                side[2] = c;
            }
        }
        public double this[int i]
        {
            get
            {
                if (i >= 0 && i < 3) //перевірка індексів
                {
                    return side[i];
                }
                else
                {
                    return -1;
                }
            }
            set
            {
                if (i >= 0 && i < 3)
                {
                    side[i] = value;
                }
            }
        }
        public double Perimeter()
        {
            return side[0] + side[1] + side[2];
        }
        public double Area()
        {
            double p = Perimeter() / 2;
            return Math.Sqrt(p * (p - side[0]) * (p - side[1]) * (p - side[2]));
        }
    }
}
