using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product
{
    enum Action
    {
        received, sold, written_off, transferred
    }
    class Management
    {
        private string nameForManagement;
        private Action _action;

        public Management(string name, Action action)
        {
            nameForManagement = name;
            _action = action;
        }

        public void Status()
        {           
                Console.WriteLine($"Product {nameForManagement} {_action}");
        }
    }
}
