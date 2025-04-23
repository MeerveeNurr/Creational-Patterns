using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_2132
{
    internal class DispatchBuilder_2132 : IDispatchBuilder_2132
    {

        private Dispatch_2132 _dispatch = new Dispatch_2132();

        public void SetName(string name)
        {
            _dispatch.Name = name;
        }

        public void SetDepartment(string department)
        {
            _dispatch.Department = department;
        }

        public Dispatch_2132 GetDispatch()
        {
            return _dispatch;
        }
    }
}
