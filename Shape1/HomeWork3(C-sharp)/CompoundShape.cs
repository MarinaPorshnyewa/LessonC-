using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3_C_sharp_
{
    class CompoundShape
    {
        private double result = 0;
        private Shape[] shape;

        public CompoundShape(Shape[] shape)
        {
            this.shape = shape;
        }
        public double AddPerimeter()
        {
            foreach(Shape item in shape)
            {
                Console.WriteLine($"{item.GetType().Name}");
                result += item.Perimeter();
            }
            return result;
        }
        public void Print()
        {
            Console.WriteLine($"Compound Shape = {result}");
        }
    }
}
