using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_2132
{
   public  interface IPoliclinicBuilder_2132
    {
        void SetName(string name);
        void SetDepartment(string department);
        Policlinic_2132 GetPoliclinic();
    }
}
