using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory_2132
{
    interface IPatientAbstractFactory_2132
    {
        string Name { get; set; }
        string Surname { get; set; }

        void AddPatient();
        void RemovePatient();
    }
}
