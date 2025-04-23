using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection_2132
{
    public class Appointment_2132 : IAppointment_2132
    {
        public void CreateAppointment(string doctorName, string patientName, DateTime date, string polyclinic)
        {
            Console.WriteLine($"Appointment added: {date.ToString("dd/MM/yyyy HH:mm")}, Dr. {doctorName}, {patientName}, {polyclinic}");
        }

        public void DeleteAppointment(string doctorName, string patientName, DateTime date)
        {
            Console.WriteLine($"Appointment deleted: {date.ToString("dd/MM/yyyy HH:mm")}, Dr. {doctorName}, {patientName}");
        }

        public void AppointmentNotFound(string doctorName, string patientName, DateTime date)
        {
            Console.WriteLine($"Appointment not found: {date.ToString("dd/MM/yyyy HH:mm")}, Dr. {doctorName}, {patientName}");
        }
    }
}
