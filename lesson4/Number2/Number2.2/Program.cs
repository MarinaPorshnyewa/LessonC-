using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
2. Разработать метод для решения системы 2 линейных
уравнений:
A1×X + B1×Y = 0
A2×X + B2×Y = 0
Метод с помощью выходных параметров должен
возвращать найденное решение или ошибку, если
решения не существует.
 */

namespace Number2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Solution solution = new Solution();
                solution.Answer();
            }
            catch(Exception myException)
            {
                Console.WriteLine(myException.Message);
            }
        }
    }
}
