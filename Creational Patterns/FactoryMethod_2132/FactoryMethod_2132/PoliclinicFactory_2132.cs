using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod_2132
{
    public class PoliclinicFactory_2132 :IPoliclinicFactory_2132
    {
        public IStaff_2132 CreatePerson(string name, string department)
        {
            return new Policlinic_2132(name, department);
        }
        public Policlinic_2132 CreatePoliclinic(string name, string department)
        {
            return new Policlinic_2132(name, department);
        }
    }



}
