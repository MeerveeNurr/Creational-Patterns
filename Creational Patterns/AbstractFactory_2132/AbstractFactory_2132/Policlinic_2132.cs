using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AbstractFactory_2132
{
    public class Policlinic_2132 : IPoliclinicAbstractFactory_2132
    {
        public string Name { get; set; }
        public int Number { get; set; }
        public Policlinic_2132(string name, int numbeer)
        {
            Name = name;
            Number = numbeer;
        }

        public void CreatePoliclinic()
        {
            Console.WriteLine($"Added policlinic: {Name}, Number: {Number}");
        }

        public void RemovePoliclinic()
        {
            Console.WriteLine($"Removed policlinic: {Name}, Number: {Number}");
        }
    }
}
