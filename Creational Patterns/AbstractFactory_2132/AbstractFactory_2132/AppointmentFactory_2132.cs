using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory_2132
{
    public class AppointmentAbstractFactory_2132 : IAppointmentAbstractFactory_2132
    {
        private List<IAppointmentAbstractFactory_2132> appointments;
        public string DoctorName { get; set; }
        public string ClinicName { get; set; }
        public DateTime Date { get; set; }

        public AppointmentAbstractFactory_2132()
        {
            appointments = new List<IAppointmentAbstractFactory_2132>();
        }
        public void CreateAppointment()
        {
            Console.WriteLine("Enter the clinic name for the new appointment:");
            ClinicName = Console.ReadLine();

            Console.WriteLine("Enter the date for the new appointment (yyyy-MM-dd):");
            Date = DateTime.Parse(Console.ReadLine());

            // Diğer gerekli işlemleri yapabilirsiniz, örneğin bir liste veya veritabanına yeni randevu ekleyebilirsiniz.
            Console.WriteLine("Appointment created successfully.");
        }
        public void RemoveAppointment()
        {
            Console.WriteLine("Enter the doctor name for the appointment you want to remove:");
            string doctorName = Console.ReadLine();

            Console.WriteLine("Enter the clinic name for the appointment you want to remove:");
            string clinicName = Console.ReadLine();

            Console.WriteLine("Enter the date for the appointment you want to remove (yyyy-MM-dd):");
            DateTime date = DateTime.Parse(Console.ReadLine());

            var appointmentToRemove = appointments.FirstOrDefault(a => a.DoctorName == doctorName && a.ClinicName == clinicName && a.Date == date);
            if (appointmentToRemove != null)
            {
                appointments.Remove(appointmentToRemove);
                Console.WriteLine("Appointment removed successfully.");
            }
            else
            {
                Console.WriteLine("Appointment not found.");
            }
        }
    }


}
