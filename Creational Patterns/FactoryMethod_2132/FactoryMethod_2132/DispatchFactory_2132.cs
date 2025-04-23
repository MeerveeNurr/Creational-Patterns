using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod_2132
{
    public class DispatchFactory_2132 : IStaffFactory_2132
    {
        public IStaff_2132 CreatePerson(string name, string department)
        {
            return new Dispatch_2132(name, department);
        }
    }
}
