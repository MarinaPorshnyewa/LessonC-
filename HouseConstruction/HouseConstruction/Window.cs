using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseConstruction
{
    class Window : IPart
    {
        
        public void PartOfHouse()
        {
            Console.WriteLine("Part Of House: " + GetType().Name);
        }
       
    }
}
