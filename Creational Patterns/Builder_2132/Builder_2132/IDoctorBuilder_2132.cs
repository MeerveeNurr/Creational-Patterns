using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Builder_2132
{
    interface IDoctorBuilder_2132
    {
        void SetName(string name);
        void SetDepartment(string department);
        Doctor_2132 GetDoctor();
    }
}
