using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod_2132
{
    public interface IPatientFactory_2132
    {
        Patient_2132 CreatePatient(string name, string department);
    }
}
