using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3_C_sharp_
{
    class Rhomb : Shape
    {
        private double _side;
        private double _height;

        public Rhomb(double side, double height)
        {
            _side = side;
            _height = height;
        }
        public override double Area()
        {
            S = _side * _height;
            return S;
        }

        public override double Perimeter()
        {
            P = 4 * _side;
            return P;
        }
        public override string ToString()
        {
            return "Rhomb:\n" + base.ToString();
        }
    }
}
