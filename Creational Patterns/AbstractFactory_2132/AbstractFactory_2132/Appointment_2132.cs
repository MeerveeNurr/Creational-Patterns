using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;

namespace AbstractFactory_2132
{
    internal class Appointment_2132 : IAppointmentAbstractFactory_2132
    {
        public string DoctorName { get; set; }
        public string ClinicName { get; set; }
        public DateTime Date { get; set; }
        public Appointment_2132(string doctorname, string clinicname, DateTime date)
        {
            DoctorName = doctorname;
            ClinicName = clinicname;
            Date = date;
        }
        public void CreateAppointment()
        {
            Console.WriteLine($"Created appointment for {DoctorName} at {ClinicName} on {Date}");
        }

        public void RemoveAppointment()
        {
            Console.WriteLine($"Removed appointment for {DoctorName} at {ClinicName} on {Date}");
        }
    }
}
