using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Num4
{
    class Fraction
    {
        private double numerator;
        private double denominator;
        private double result;

        public Fraction() { }

        public Fraction(double numerator, double denominator)
        {
            this.numerator = numerator;
            this.denominator = denominator;
            this.result = numerator / denominator;
        }
        public override string ToString()
        {
            return string.Format("{0}/{1} = {2}", numerator, denominator, result);
        }
        public static Fraction operator *(Fraction A, Fraction B)
        {

            return new Fraction(A.numerator * B.numerator, A.denominator * B.denominator);
        }
        public static Fraction operator *(Fraction A, double x)
        {

            return new Fraction(A.numerator * x, A.denominator);
        }
        public static Fraction operator *(double x, Fraction A)
        {

            return new Fraction(x * A.numerator, A.denominator);
        }

        public static Fraction operator +(Fraction A, Fraction B)
        {

            return new Fraction((A.numerator * B.denominator) + (B.numerator * A.denominator), (A.denominator * B.denominator));
        }


        public static Fraction operator +(Fraction A, double x)
        {

            return new Fraction((A.numerator + (x * A.denominator)), A.denominator);
        }

        public static Fraction operator -(Fraction A, Fraction B)
        {

            return new Fraction((A.numerator * B.denominator) - (B.numerator * A.denominator), (A.denominator * B.denominator));
        }
        public static Fraction operator /(Fraction A, Fraction B)
        {

            return new Fraction(A.numerator * B.denominator, A.denominator * B.numerator);
        }

        public override bool Equals(object obj)
        {
            return this.ToString() == obj.ToString();
        }

        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }

        public static bool operator ==(Fraction A, Fraction B)
        {
            return A.Equals(B);
        }
        public static bool operator !=(Fraction A, Fraction B)
        {
            return !(A == B);
        }

        public static bool operator >(Fraction A, Fraction B)
        {
            return (A.numerator / A.denominator) > (B.numerator / B.denominator);
        }
        public static bool operator <(Fraction A, Fraction B)
        {
            return (A.numerator / A.denominator) < (B.numerator / B.denominator);
        }
        public static bool operator true(Fraction A)
        {
            return A.numerator < A.denominator ? true : false;
        }
        public static bool operator false(Fraction A)
        {
            return A.numerator > A.denominator ? true : false;
        }

    }
}
