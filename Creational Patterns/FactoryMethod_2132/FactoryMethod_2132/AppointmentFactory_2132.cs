using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod_2132
{
    public class AppointmentFactory_2132 : IAppointmentFactory_2132
    {
        public IStaff_2132 CreatePerson(string name, string department)
        {
           
            IStaff_2132 doctor = new Doctor_2132("Dr. Merve", "Cardiology");

           
            return new Appointment_2132(DateTime.Now, doctor, new Patient_2132(name, department));
        }
        public Appointment_2132 CreateAppointment(DateTime date, Patient_2132 patient, Doctor_2132 doctor)
        {
            return new Appointment_2132(date, patient, doctor);
        }
    }

}
