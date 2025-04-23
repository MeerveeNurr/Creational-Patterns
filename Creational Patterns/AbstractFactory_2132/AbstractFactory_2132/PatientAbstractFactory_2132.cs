using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory_2132
{
    internal class PatientAbstractFactory_2132 : IAbstractFactory_2132
    {
        public IPatientAbstractFactory_2132 CreatePatient(string name, string surname)
        {
            return new Patient_2132(name, surname);
        }

        public IDoctorAbstractFactory_2132 CreateDoctor(string name, string surname, string department)
        {
            return new Doctor_2132(name, surname, department);
        }

        public IAppointmentAbstractFactory_2132 CreateAppointment(string doctorName, string clinicName, DateTime date)
        {
            return new Appointment_2132(doctorName, clinicName, date);
        }

        public IPoliclinicAbstractFactory_2132 CreateDepartment(string name, int number)
        {
            return new Policlinic_2132(name, number);
        }
    }
}
