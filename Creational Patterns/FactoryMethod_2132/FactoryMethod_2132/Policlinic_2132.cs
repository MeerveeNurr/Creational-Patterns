using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod_2132
{
    public class Policlinic_2132 : IStaff_2132
    {
        public string Name { get; }
        public string Department { get; }
        public List<IStaff_2132> Doctors { get; }

        public Policlinic_2132(string name, string department)
        {
            Name = name;
            Department = department;
            Doctors = new List<IStaff_2132>();
        }

        public void AddDoctor(IStaff_2132 doctor)
        {
            Doctors.Add(doctor);
            Console.WriteLine("Doctor added to policlinic: " + doctor.Name + " (Department: " + doctor.Department + ")");
        }

        public void RemoveDoctor(IStaff_2132 doctor)
        {
            Doctors.Remove(doctor);
            Console.WriteLine("Doctor removed from policlinic: " + doctor.Name);
        }
    }
}