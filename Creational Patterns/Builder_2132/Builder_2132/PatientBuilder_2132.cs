using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_2132
{
    internal class PatientBuilder_2132 :IPatientBuilder_2132
    {
        private Patient_2132 _patient = new Patient_2132();

        public void SetName(string name)
        {
            _patient.Name = name;
        }

        public void SetDepartment(string department)
        {
            _patient.Department = department;
        }

        public Patient_2132 GetPatient()
        {
            return _patient;
        }
    }
}
