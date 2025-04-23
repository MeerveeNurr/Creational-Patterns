using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection_2132
{
    public class Doctor_2132 : IDoctor_2132
    {
        public void AddDoctor(string doctorname)
        {
            Console.WriteLine($"Doctor added: {doctorname}");
        }

        public void RemoveDoctor(string doctorname)
        {
            Console.WriteLine($"Patient removed: {doctorname}");
        }

        public void DoctorNotFound(string doctorname)
        {
            Console.WriteLine($"Patient {doctorname} not found.");
        }
    }


}
