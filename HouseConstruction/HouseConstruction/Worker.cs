using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseConstruction
{
    class Worker : Team, IWorker
    {
        public string _workWorker;
        public Worker(string name, int age) : base(name, age)
        {
            _workWorker = "build a house";
        }

        public override void Report()
        {
        }

        public override string ToString()
        {
            return base.ToString()+$" {_workWorker}";
        }
    }
}
