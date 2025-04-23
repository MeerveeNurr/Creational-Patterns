using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory_2132
{
    public class Patient_2132 : IPatientAbstractFactory_2132
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        public Patient_2132(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }

        public void AddPatient()
        {
            Console.WriteLine($"Added patient: {Name} {Surname}");
        }

        public void RemovePatient()
        {
            Console.WriteLine($"Removed patient: {Name} {Surname}");
        }

    }

}
