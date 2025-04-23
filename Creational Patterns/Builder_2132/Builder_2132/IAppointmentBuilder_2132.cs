using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_2132
{
    interface IAppointmentBuilder_2132
    {
        void SetDoctor(string name, string department);
        void SetDispatch(string name, string department);
        void SetPatient(string name, string department);
        void SetDate(DateTime date);
        void Build();
    }
}
