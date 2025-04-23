using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod_2132
{
    internal class PatientFactory_2132 : IPatientFactory_2132
    {
        public IStaff_2132 CreatePerson(string name, string department)
        {
            return new Patient_2132(name, department);
        }
        public Patient_2132 CreatePatient(string name, string department)
        {
            return new Patient_2132(name, department);
        }
        public void RemovePatient(IStaff_2132 patient)
        {
           
            Console.WriteLine("Patient removed: " + patient.Name);
        }
    }
}
