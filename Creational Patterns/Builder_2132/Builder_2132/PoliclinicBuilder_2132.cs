using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_2132
{
    public class PoliclinicBuilder_2132 :IPoliclinicBuilder_2132 
    {
        private Policlinic_2132 _policlinic = new Policlinic_2132();

        public void SetName(string name)
        {
            _policlinic.Name = name;
        }

        public void SetDepartment(string department)
        {
            _policlinic.Department = department;
        }

        public Policlinic_2132 GetPoliclinic()
        {
            return _policlinic;
        }
    }
}
