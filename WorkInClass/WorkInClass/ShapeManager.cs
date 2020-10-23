using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkInClass
{
    enum CompareOption
    {
        Perimeter, Area
    }
    class ShapeManager
    {
        private double result = 0;
        private Shape shape;
        private CompareOption option;
         public ShapeManager(Shape shape, CompareOption option)
        {
            this.shape = shape;
            this.option = option;
        }

        public void Choice()
        {
            switch (option)
            {
                case CompareOption.Perimeter:                   
                        result=shape.Perimeter();                   
                    break;

                case CompareOption.Area:                   
                        result= shape.Area();                   
                    break;
            }
        }       
        public void Print()
        {
            Console.WriteLine($"Compound Shape = {result}");
        }
    }
}
