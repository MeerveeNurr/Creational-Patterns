using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory_2132
{
    public class DoctorAbstractFactory_2132 : IDoctorAbstractFactory_2132
    {
        private List<Doctor_2132> doctors;

        public DoctorAbstractFactory_2132()
        {
            doctors = new List<Doctor_2132>();
        }

        public void CreateDoctor()
        {
            Console.WriteLine("Enter the name of the new doctor:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter the surname of the new doctor:");
            string surname = Console.ReadLine();

            Console.WriteLine("Enter the department of the new doctor:");
            string department = Console.ReadLine();

            var newDoctor = new Doctor_2132(name, surname, department);
            doctors.Add(newDoctor);

            Console.WriteLine("Doctor created successfully.");
        }

        public void RemoveDoctor()
        {
            Console.WriteLine("Enter the name of the doctor you want to remove:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter the surname of the doctor you want to remove:");
            string surname = Console.ReadLine();

            var doctorToRemove = doctors.Find(d => d.Name == name && d.Surname == surname);
            if (doctorToRemove != null)
            {
                doctors.Remove(doctorToRemove);
                Console.WriteLine("Doctor removed successfully.");
            }
            else
            {
                Console.WriteLine("Doctor not found.");
            }
        }
    }

}