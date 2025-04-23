using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AbstractFactory_2132
{
    internal class DispatchAbstractFactory_2132
    {
        public IDoctorAbstractFactory_2132 CreateDoctor(string name, string surname, string department)
        {
            return new Doctor_2132(name, surname, department);
        }

        public IPatientAbstractFactory_2132 CreatePatient(string name, string surname ,string department)
        {
            return new Patient_2132(name, department);
        }

        public IDispatchAbstractFactory_2132 CreateDispatch(string name, string department)
        {
            return new Dispatch_2132(name, department);
        }

        public IAppointmentAbstractFactory_2132 CreateAppointment(string doctorname, string clinicname, DateTime date)
        {
            return new Appointment_2132(doctorname, clinicname, date);
        }
    }
}
