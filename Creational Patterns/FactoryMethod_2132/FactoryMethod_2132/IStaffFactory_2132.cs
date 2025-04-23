using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod_2132
{
    public interface IStaffFactory_2132
    {
        IStaff_2132 CreatePerson(string name, string department);
    }
    }
