using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Builder_2132
{

    class AppointmentBuilder_2132 : IAppointmentBuilder_2132
    {
        private Appointment_2132 _appointment = new Appointment_2132();

        public void SetDoctor(string name, string department)
        {
            _appointment.Doctor = new Doctor_2132 { Name = name, Department = department };
        }

        public void SetDispatch(string name, string department)
        {
            _appointment.Dispatch = new Dispatch_2132 { Name = name, Department = department };
        }

        public void SetPatient(string name, string department)
        {
            _appointment.Patient = new Patient_2132 { Name = name, Department = department };
        }

        public void SetDate(DateTime date)
        {
            _appointment.Date = date;
        }

        public void Build()
        {

            Console.WriteLine("Appointment built");
        }

        public Appointment_2132 GetAppointment()
        {
            return _appointment;
        }
    }

}
