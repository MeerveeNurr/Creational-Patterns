using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_2132
{
    interface IDispatchBuilder_2132
    {
        void SetName(string name);
        void SetDepartment(string department);
        Dispatch_2132 GetDispatch();
    }
}
