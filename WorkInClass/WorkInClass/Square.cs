using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkInClass
{
    class Square:Shape
    {
        private double _side;

        public Square(double side)
        {
            _side = side;
        }
        public override double Area()
        {
            S = _side * _side;
            return S;
        }

        public override double Perimeter()
        {
            P = 4 * _side;
            return P;
        }

        public override string ToString()
        {
            return "Square:\n" + base.ToString();
        }
    }
}
