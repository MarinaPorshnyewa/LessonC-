using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product
{
    abstract class Product
    {
        protected string _category;
        public string _name;
        protected double _price;

        public Product(string name, double price)
        {
            _name = name;
            _price = price;
        }
            

        public override string ToString()
        {
            return $"Category of product: {_category}\nName of product: {_name}\n" +
                $"Price of product: {_price}\n";
        }

    }
}
