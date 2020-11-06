using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number2._2
{
    class Solution
    {
        private int A1;
        private int B1;
        private int A2;
        private int B2;

        public void EnterValue()
        {
            Console.WriteLine("Enter A1: ");
            A1 = Int16.Parse(Console.ReadLine());
            Console.WriteLine("Enter B1: ");
            B1 = Int16.Parse(Console.ReadLine());
            Console.WriteLine("Enter A2: ");
            A2 = Int16.Parse(Console.ReadLine());
            Console.WriteLine("Enter B2: ");
            B2 = Int16.Parse(Console.ReadLine());
            Console.WriteLine("{0}*X + {1}*Y = 0 \n{2}*X + {3}*Y = 0", A1, B1, A2, B2);
        }

        public void Answer()
        {
            EnterValue();
             
            if (A1==0 && B1==0 && A2==0 && B2==0)
            {
                throw new Exception("Error: all variables are zero, no solution!");
            }
            else if ((A1 != 0 || B1 != 0) && A2 == 0 && B2 == 0)
            {
                throw new Exception("Error: there is no second line!");
            }
            else if (A1 == 0 && A1 == 0 && (A2 != 0 || B2 != 0))
            {
                throw new Exception("Error: there is no first line!");
            }
            else if((A1 == A2) && (B1 == B2))
            {
                Console.WriteLine("Lines coincident");
            }
            else if (A1 * B2 == B1 * A2)
            {
                Console.WriteLine("Lines coincident");
            }
            else
            {
                Console.WriteLine("X = 0 \nY = 0");
            }
        }
    }
}
