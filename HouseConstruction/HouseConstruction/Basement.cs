using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseConstruction
{
    class Basement : IPart
    {
        
        public void PartOfHouse()
        {
            Console.WriteLine("Part Of House: " + GetType().Name);
        }
    }
}
