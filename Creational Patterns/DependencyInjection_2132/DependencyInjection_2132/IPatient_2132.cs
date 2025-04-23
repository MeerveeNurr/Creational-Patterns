using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection_2132
{
    public interface IPatient_2132
    {
        void AddPatient(string name, string surname, int age);
        void RemovePatient(string name, string surname,int age);
        public void PatientNotFound(string name, string surname, int age);
    }
}
