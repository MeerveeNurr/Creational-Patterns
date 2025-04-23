using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory_2132
{
    interface IPoliclinicAbstractFactory_2132
    {

        string Name { get; set; }
        int Number { get; set; }

        void CreatePoliclinic(); 
        void RemovePoliclinic();
    }
}
