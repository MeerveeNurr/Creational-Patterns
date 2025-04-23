using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Builder_2132
{
    internal class Appointment_2132 : IStaff_2132
    {
        public string Name { get; set; }
        public string Department { get; set; }
        public DateTime Date { get; set; }
        public Patient_2132 Patient { get; set; }
        public Doctor_2132 Doctor { get; set; }

        public Dispatch_2132 Dispatch { get; set; }

        public override string ToString()
        {
            return $"Doctor: {Doctor.Name}, Patient: {Patient.Name}, Policlinic: {Department}, Date: {Date}";
        }
        public string Details()
        {
            return "Appointment Deleted.Please make a new appointment..."; 
        }
    }
}
