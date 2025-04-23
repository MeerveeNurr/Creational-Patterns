using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection_2132
{
    public interface IAppointment_2132
    {
        void CreateAppointment(string doctorName, string patientName, DateTime date, string polyclinic);
        void DeleteAppointment(string doctorName, string patientName, DateTime date);

        public void AppointmentNotFound(string doctorName, string patientName, DateTime date);
    }
}
