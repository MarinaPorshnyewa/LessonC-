using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexValue
{
    class ComplexNum
    {
        private double A;
        private double B;
        public ComplexNum() { }
        public ComplexNum(double real, double imaginary)
        {
            A = real;
            B = imaginary;
        }
        public static ComplexNum operator +(ComplexNum X, ComplexNum Y)
        {           
            return new ComplexNum(X.A + Y.A, X.B + Y.B);
        }
        public static ComplexNum operator -(ComplexNum X, ComplexNum Y)
        {
            return new ComplexNum(X.A - Y.A, X.B - Y.B);
        }
        public static ComplexNum operator *(ComplexNum X, ComplexNum Y)
        {
            return new ComplexNum(((X.A * Y.A) - (X.B * Y.B)), ((X.B * Y.A) + (X.A * Y.B)));
        }
        public static ComplexNum operator /(ComplexNum X, ComplexNum Y)
        {
            return new ComplexNum(((X.A * Y.A) +(X.B * Y.B))/((Y.A)* (Y.A)+ (Y.B) * (Y.B)), ((X.B * Y.A) - (X.A * Y.B))/ ((Y.A) * (Y.A) + (Y.B) * (Y.B)));
        }

        public static ComplexNum operator *(double n, ComplexNum X)
        {
            return new ComplexNum(3 * X.A, 3 * X.B);
        }
        public static ComplexNum operator -(ComplexNum X, double n)
        {
            return new ComplexNum(X.A - n, X.B - n);
        }
        public override string ToString()
        {
            return string.Format("{0} + {1}i", A, B);
        }
    }
}
