using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection_2132
{
    public class Patient_2132 : IPatient_2132
    {
        public void AddPatient(string name, string surname, int age)
        {
            Console.WriteLine($"Patient added: {name} {surname}, {age} years old");
        }

        public void RemovePatient(string name, string surname, int age)
        {
            Console.WriteLine($"Patient removed: {name} {surname}, {age} years old");
        }

        public void PatientNotFound(string name, string surname,int age)
        {
            Console.WriteLine($"Patient {name} {surname} not found.");
        }
    }


}
