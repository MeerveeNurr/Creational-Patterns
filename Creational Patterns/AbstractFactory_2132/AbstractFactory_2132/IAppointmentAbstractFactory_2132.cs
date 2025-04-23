using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory_2132
{
   interface IAppointmentAbstractFactory_2132
    {
        string DoctorName { get; set; }
        string ClinicName { get; set; }
        DateTime Date { get; set; }

        void CreateAppointment();
        void RemoveAppointment();
    }
    }

