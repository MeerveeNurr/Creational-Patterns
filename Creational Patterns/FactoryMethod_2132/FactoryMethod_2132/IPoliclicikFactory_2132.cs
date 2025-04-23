using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod_2132
{

    public interface IPoliclinicFactory_2132
    {
        Policlinic_2132 CreatePoliclinic(string name, string department);
    }
}
