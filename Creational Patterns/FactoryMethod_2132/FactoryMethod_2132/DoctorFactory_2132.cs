using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod_2132
{
    internal class DoctorFactory_2132 : IDoctorFactory_2132
    {
        public IStaff_2132 CreatePerson(string name, string department)
        {
            return new Doctor_2132(name, department);
        }
        public Doctor_2132 CreateDoctor(string name, string department)
        {
            return new Doctor_2132(name, department);
        }
        public void RemoveDoctor(IStaff_2132 doctor)
        {
            List<IStaff_2132> doctors = new List<IStaff_2132>();

            
            doctors.Remove(doctor);

           
            Console.WriteLine("Doctor removed: " + doctor.Name);
        }

    }
}
