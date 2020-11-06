using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 1.	Разработать собственный структурный тип данных
для хранения целочисленных коэффициентов A и B
линейного уравнения A×X + B×Y = 0. в классе реали-
зовать статический метод Parse(), которые принимает
строку со значениями коэффициентов, разделенных
запятой или пробелом.
 */

namespace Number2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
                Console.WriteLine("Enter 2 values with , or  :");
                try
                {
                    MyType.Parse(Console.ReadLine());
                }
                catch (FormatException multiplier)

                {
                    Console.WriteLine(multiplier.Message);
                    Console.WriteLine();
                }
                Console.WriteLine("{0}*X + {1}*Y = 0", MyType.A, MyType.B);
                Console.WriteLine();
            
        }
    }
}
