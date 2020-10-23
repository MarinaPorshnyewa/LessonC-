using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product
{
    class Food : Product
    {

        public Food(string name, double price) : base(name, price) 
        {
            _category = GetType().Name;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
