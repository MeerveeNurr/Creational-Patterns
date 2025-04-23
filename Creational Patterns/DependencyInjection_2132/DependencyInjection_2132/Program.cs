using Autofac;
using System;

namespace DependencyInjection_2132
{
    class Program
    {
        static void Main()
        {
            // DI konteyneri oluşturuldu.
            var builder = new ContainerBuilder();
            builder.RegisterType<Doctor_2132>().As<IDoctor_2132>();
            builder.RegisterType<Patient_2132>().As<IPatient_2132>();
            builder.RegisterType<Appointment_2132>().As<IAppointment_2132>();
            builder.RegisterType<Policlinic_2132>().As<IPoliclinic_2132>();
            var container = builder.Build();

            var doctorService = container.Resolve<IDoctor_2132>();
            var patientService = container.Resolve<IPatient_2132>();
            var appointmentService = container.Resolve<IAppointment_2132>();
            var polyclinicService = container.Resolve<IPoliclinic_2132>();

            var hospital = new DependecyInjection_2132(doctorService, patientService, appointmentService, polyclinicService);

            hospital.AddDoctor("Tahir");
            hospital.AddDoctor("Asiye");
            hospital.AddDoctor("Tİmur");

            hospital.RemoveDoctor("Bahar");
            hospital.RemoveDoctor("Eylül");
            hospital.RemoveDoctor("Mert");
            Console.WriteLine("Doctor not found");

            hospital.AddPatient("Ahmet", "Kaş", 30);
            hospital.AddPatient("Ayşe", "Aslan", 24);
            hospital.AddPatient("Elvin", "Kaplan", 7);
            Console.WriteLine("Patient not found");



            hospital.CreateAppointment("Dr. Mehmet", "Ahmet", new DateTime(2025, 01, 01, 14, 30, 00), "Cardiology");
            hospital.CreateAppointment("Dr. Merve", "Ayşe", new DateTime(2025, 01, 01, 14, 30, 00), "KBB");
            hospital.CreateAppointment("Dr. Ekin", "Elvin", new DateTime(2025, 01, 01, 14, 30, 00), "Dermatology");
            Console.WriteLine("Appointment not found");
    

            hospital.RemovePatient("Sefa", "Koç", 35);
            hospital.RemovePatient("Eslina", "Kara", 19);
            hospital.RemovePatient("Haluk", "Levent", 55);


            hospital.DeleteAppointment("Dr. Ömer", "Nur", new DateTime(2025, 01, 01, 14, 30, 00));
            hospital.DeleteAppointment("Dr. Harun", "Veli", new DateTime(2025, 01, 01, 14, 30, 00));
            hospital.DeleteAppointment("Dr. Bilal", "Zeybek", new DateTime(2025, 01, 01, 14, 30, 00));

            hospital.AddPoliklinik("Cardiology");
            hospital.AddPoliklinik("KBB");
            hospital.AddPoliklinik("Eye polyclinic");

            hospital.RemovePoliklinik("Dentistry");
            hospital.RemovePoliklinik("General Surgery");
            hospital.RemovePoliklinik("Orthopedics");
            Console.WriteLine("Policlinic not found");
        }
    }
}
