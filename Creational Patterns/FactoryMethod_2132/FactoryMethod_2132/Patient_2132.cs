using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod_2132
{
    public class Patient_2132 :IStaff_2132 // hasta
    {
        public string Name { get; }
        public string Department { get; }

        public Patient_2132(string name, string department)
        {
            Name = name;
            Department = department;
        }
    }
}
