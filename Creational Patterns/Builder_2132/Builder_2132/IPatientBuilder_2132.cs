using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_2132
{
    interface IPatientBuilder_2132
    {
        void SetName(string name);
        void SetDepartment(string department);
        Patient_2132 GetPatient();
    }
}
