using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product
{
    class HouseholdChemicals: Product
    {
        public HouseholdChemicals(string name, double price) : base(name, price)
        {
            _category = GetType().Name;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
