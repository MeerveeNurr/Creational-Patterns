using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod_2132
{
    public interface IDoctorFactory_2132
    {
        Doctor_2132 CreateDoctor(string name, string department);
    }

}
