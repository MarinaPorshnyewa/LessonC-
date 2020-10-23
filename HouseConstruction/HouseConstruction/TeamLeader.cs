using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseConstruction
{
    class TeamLeader : Team, IWorker
    {
        public string _workTeamLeader;
        public TeamLeader(string name,int age) : base(name, age) 
        {
            _workTeamLeader = "generates a report";
        }
 
        public override string ToString()
        {
            return base.ToString()+$" {_workTeamLeader}";
        }

        public override void Report()
        {
            Console.WriteLine("The house is built! Writing a report!"); 
        }
    }
}
