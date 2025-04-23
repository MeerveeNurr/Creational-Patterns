using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Builder_2132
{
    public class DoctorBuilder_2132 : IDoctorBuilder_2132
    {
            private Doctor_2132 _doctor = new Doctor_2132();

            public void SetName(string name)
            {
                _doctor.Name = name;
            }

            public void SetDepartment(string department)
            {
                _doctor.Department = department;
            }
             public Doctor_2132 GetDoctor()
             {
            return _doctor;
             }
    }
    }

