using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory_2132
{
    public class Dispatch_2132 : IDispatchAbstractFactory_2132
    {
        public string Name { get; set; }
        public string Department { get; set; }

        public Dispatch_2132(string name, string department)
        {
            Name = name;
            Department = department;
        }
    }
}
