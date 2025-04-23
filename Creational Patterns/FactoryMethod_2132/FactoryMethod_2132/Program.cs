using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace FactoryMethod_2132
{
    class Program
    {
        static void Main(string[] args)
        {
            IDoctorFactory_2132 doctorFactory = new DoctorFactory_2132();
            IStaff_2132 doctor1 = doctorFactory.CreateDoctor("Dr. Merve", "Cardiology");

            Console.WriteLine("Doctor added to policlinic: " + doctor1.Name + " (Department: " + doctor1.Department + ")");
            IStaffFactory_2132 dispatchFactory = new DispatchFactory_2132();
            IStaff_2132 dispatch1 = dispatchFactory.CreatePerson("Ahmet", "Emergency Department");

            Console.WriteLine("Dispatch created: " + dispatch1.Name + " (Department: " + dispatch1.Department + ")");

            IPatientFactory_2132 patientFactory = new PatientFactory_2132();
            IStaff_2132 patient1 = patientFactory.CreatePatient("Luna", "Heart Clinic");

            Console.WriteLine("Patient created: " + patient1.Name + " (Department: " + patient1.Department + ")");
          
            
            Policlinic_2132 heartClinic = new Policlinic_2132("Heart Clinic", "Cardiology");
            heartClinic.AddDoctor(doctor1);
            Console.WriteLine("Policlinic created: " + heartClinic.Name + " (Department: " + heartClinic.Department + ")");
            
            Appointment_2132 appointment = new Appointment_2132(DateTime.Now, patient1, doctor1);

            
            Console.WriteLine("Appointment Created:");
            Console.WriteLine("Date: " + appointment.Date);
            Console.WriteLine("Patient: " + appointment.Patient.Name);
            Console.WriteLine("Doctor: " + appointment.Doctor.Name);
            Console.WriteLine("Clinic: " + heartClinic.Name);

           
            PatientFactory_2132 patientFactory2 = new PatientFactory_2132();
            patientFactory2.RemovePatient(patient1);
          //  Console.WriteLine("\n");

           
           DoctorFactory_2132 doctorFactory2 = new DoctorFactory_2132();
            doctorFactory2.RemoveDoctor(doctor1); 

          //  Console.WriteLine("\n");

          
            appointment.RemoveAppointment();
        }
    }
}