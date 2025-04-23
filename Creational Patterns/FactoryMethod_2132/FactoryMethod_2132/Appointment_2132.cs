using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod_2132
{
    public class Appointment_2132 : IStaff_2132
    {
        public DateTime Date { get; }
        public string Name { get; }
        public string Department { get; }

        public IStaff_2132 Patient { get; }
        public IStaff_2132 Doctor { get; }

        public Appointment_2132(DateTime date, IStaff_2132 patient, IStaff_2132 doctor)
        {
            Date = date;
            Patient = patient;
            Doctor = doctor;
        }
        public void RemoveAppointment()
        {
           
            Console.WriteLine("Appointment removed");
        }
    }

}
