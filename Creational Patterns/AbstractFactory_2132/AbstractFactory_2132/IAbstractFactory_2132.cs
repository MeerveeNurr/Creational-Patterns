using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory_2132
{ 
        interface IAbstractFactory_2132
        {
        IPatientAbstractFactory_2132 CreatePatient(string name, string surname);
        IDoctorAbstractFactory_2132 CreateDoctor(string name, string surname, string department);
        IAppointmentAbstractFactory_2132 CreateAppointment(string doctorName, string clinicName, DateTime date);
        IPoliclinicAbstractFactory_2132 CreateDepartment(string name, int number);
    }
    }

