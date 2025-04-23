using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AbstractFactory_2132
{
    public class Doctor_2132 : IDoctorAbstractFactory_2132
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Department { get; set; }

        public Doctor_2132(string name, string surname, string department)
        {
            Name = name;
            Surname = surname;
            Department = department;
        }
        public void CreateDoctor()
        {
            Console.WriteLine($"Doctor {Name} {Surname} created in {Department} department.");
        }
        public void RemoveDoctor()
        {
            Console.WriteLine($"Doctor {Name} {Surname} removed from {Department} department.");
        }
    }

}
