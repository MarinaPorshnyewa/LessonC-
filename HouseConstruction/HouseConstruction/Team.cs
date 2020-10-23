using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseConstruction
{
    abstract class Team:IWorker
    {
        protected string _name;
        protected int _age;

        public Team(string name, int age)
        {
            _name = name;
            _age = age;
        }

        public override string ToString()
        {
            return $"Name: {_name}, Age: {_age}";
        }

        public void TypeOfWorker()
        {
            Console.WriteLine("Type Of Worker: " + GetType().Name);
        }
        abstract public void Report();      
    }
}
