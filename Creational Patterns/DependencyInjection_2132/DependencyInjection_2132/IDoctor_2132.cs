using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection_2132
{
    public interface IDoctor_2132
    {
            void AddDoctor(string doctorName);
            void RemoveDoctor(string doctorName);
        public void DoctorNotFound(string doctorName);
    }
}
