using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3_C_sharp_
{
    class Circle : Shape
    {
        private double _radius;

        public Circle(double radius)
        {
            _radius = radius;
        }

        public override double Area()
        {
            S = Math.PI * _radius * _radius;
            return S;
        }

        public override double Perimeter()
        {
            P = 2 * _radius * Math.PI;
            return P;
        }
        public override string ToString()
        {
            return "Circle:\n" + base.ToString();
        }
    }
}
