using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
4.	Разработать класс Fraction, представляющий простую
дробь. в классе предусмотреть два поля: числитель
и знаменатель дроби. Выполнить перегрузку следу-
ющих операторов: +,-,*,/,==,!=,<,>, true и false.
Арифметические действия и сравнение выполняется
в соответствии с правилами работы с дробями. Опе-
ратор true возвращает true если дробь правильная
(числитель меньше знаменателя), оператор false
возвращает true если дробь неправильная (числитель
больше знаменателя).
Выполнить перегрузку операторов, необходимых для
успешной компиляции следующего фрагмента кода:
Fraction f = new Fraction(3, 4);
int a = 10;
Fraction f1 = f * a;
Fraction f2 = a * f;
double d = 1.5;
Fraction f3 = f + d;
 */

namespace Num4
{
    class Program
    {
        static void Main(string[] args)
        {
            Fraction f = new Fraction(3, 4);
            int a = 10;

            Fraction f1 = f * a;
            Fraction f2 = a * f;

            Console.WriteLine(f1);
            Console.WriteLine(f2);

            double d = 1.5;
            Fraction f3 = f + d;
            Console.WriteLine(f3);

        }
    }
}
