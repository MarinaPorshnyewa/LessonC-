using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkInClass
{
    class Triangle:Shape
    {
        private double _side1;
        private double _side2;
        private double _side3;
        private double _halfP;

        public Triangle(double side1, double side2, double side3)
        {
            _side1 = side1;
            _side2 = side2;
            _side3 = side3;
        }
        public override double Area()
        {
            P = _side1 + _side2 + _side3;
            _halfP = (P / 2);
            S = Math.Sqrt(_halfP * (_halfP - _side1) * (_halfP - _side2) * (_halfP - _side3));
            return S;

        }

        public override double Perimeter()
        {
            P = _side1 + _side2 + _side3;
            return P;
        }

        public override string ToString()
        {
            return "Triangle:\n" + base.ToString();
        }
    }
}
