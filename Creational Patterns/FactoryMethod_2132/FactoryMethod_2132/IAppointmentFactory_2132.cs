using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod_2132
{
    public interface IAppointmentFactory_2132
    {
        Appointment_2132 CreateAppointment(DateTime date, Patient_2132 patient, Doctor_2132 doctor);
    }
}
