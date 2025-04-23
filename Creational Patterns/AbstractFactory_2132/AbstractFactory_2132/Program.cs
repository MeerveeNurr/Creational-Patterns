using System;

namespace AbstractFactory_2132
{
    class Program
    {
        static void Main(string[] args)
        {
            PoliclinicAbstractFactory_2132 factory = new PoliclinicAbstractFactory_2132();
            PatientAbstractFactory_2132 factory2 = new PatientAbstractFactory_2132();
            DoctorAbstractFactory_2132 factory3 = new DoctorAbstractFactory_2132();
            AppointmentAbstractFactory_2132 factory4 = new AppointmentAbstractFactory_2132();

            IPoliclinicAbstractFactory_2132 department = factory.CreateDepartment("Cardiology", 10);
            department.CreatePoliclinic();
            IPoliclinicAbstractFactory_2132 department1 = factory.CreateDepartment("Dentistry", 12);
            department1.CreatePoliclinic();
            IPoliclinicAbstractFactory_2132 department2 = factory.CreateDepartment("KBB", 16);
            department2.CreatePoliclinic();


            IPatientAbstractFactory_2132 patient = factory.CreatePatient("Ahmet", "Aslan");
            patient.AddPatient();
            IPatientAbstractFactory_2132 patient1 = factory.CreatePatient("Ali", "Koç");
            patient1.AddPatient();
            IPatientAbstractFactory_2132 patient2 = factory.CreatePatient("Veli", "Kaplan");
            patient2.AddPatient();


            IDoctorAbstractFactory_2132 doctor = factory.CreateDoctor("Ekim", "Akın", "Cardiology");
            doctor.CreateDoctor();
            IDoctorAbstractFactory_2132 doctor1 = factory.CreateDoctor("Oğuz", "Kaya", "General Surgery");
            doctor1.CreateDoctor();
            IDoctorAbstractFactory_2132 doctor2 = factory.CreateDoctor("Eray", "Kara", "Kbb");
            doctor2.CreateDoctor();


            IAppointmentAbstractFactory_2132 appointment = factory.CreateAppointment("Erdem Eldem", "Cardiology Clinic", DateTime.Now);
            appointment.CreateAppointment();
            IAppointmentAbstractFactory_2132 appointment1 = factory.CreateAppointment("Emir Uyar", "Eye Clinic", DateTime.Now);
            appointment1.CreateAppointment();
            IAppointmentAbstractFactory_2132 appointment2 = factory.CreateAppointment("Musa Arslan", "Dermetology Clinic", DateTime.Now);
            appointment2.CreateAppointment();


            department.RemovePoliclinic();

            patient.RemovePatient();
            doctor.RemoveDoctor();
            appointment.RemoveAppointment();
        }
    }
}
