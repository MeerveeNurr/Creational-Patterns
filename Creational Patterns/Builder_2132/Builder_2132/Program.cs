
using System;

namespace Builder_2132
{
    // AppointmentDirector_2132 sınıfı, builder tasarım deseni içindeki direktör (director) rolünü üstlenir.
    // Builder deseninde, direktör, karmaşık nesnelerin oluşturulma sürecini yönetir
    // ve builder sınıflarını kullanarak nesnelerin adım adım oluşturulmasını sağlar. Direktör,
    // farklı builder sınıflarını kullanarak farklı türde nesnelerin oluşturulmasını kolaylaştırır
    // ve bu işlemi müşteri sınıfından (örneğin Program sınıfı) soyutlar.
    class Program
    {
        static void Main(string[] args)

        {
            AppointmentDirector_2132 director = new AppointmentDirector_2132(new AppointmentBuilder_2132());

            IDoctorBuilder_2132 doctorBuilder = new DoctorBuilder_2132();
            director.ConstructDoctorAppointment(doctorBuilder, "Dr. Merve \n ","Cardiology");

            IStaff_2132 doctor = doctorBuilder.GetDoctor();
            Console.WriteLine("Doctor added to policlinic : \n " + doctor.Name + " (Department: \n " + doctor.Department + ")");
            Doctor_2132 doctor2 = new Doctor_2132 { Name = "Dr.Rümeysa \n ", Department = "Internal medicine \n" };
            Patient_2132 patient = new Patient_2132 { Name = "Osman \n " };
            Dispatch_2132 dispatch = new Dispatch_2132 { Name = "Fatma \n ", Department = "Emergency Department" };
            Policlinic_2132 policlinic = new Policlinic_2132 { Name = "Heart Clinic \n " , Department = "Cardiology" };

            Appointment_2132 appointment = new Appointment_2132
            {
                Doctor = doctor2,
                Patient = patient,
                Dispatch = dispatch,
                Department = policlinic.Department,
                Date = DateTime.Now
            };

            Console.WriteLine("Appointment Created : \n " + appointment.ToString());


            IDispatchBuilder_2132 dispatchBuilder = new DispatchBuilder_2132();
            director.ConstructDispatchAppointment(dispatchBuilder,"Ahmet Aslan \n ","Emergency Department");

            IStaff_2132 dispatch2 = dispatchBuilder.GetDispatch();
            Console.WriteLine("Dispatch created: " + dispatch2.Name + "(Department: \n  " + dispatch2.Department + ")");

            IPatientBuilder_2132 patientBuilder = new PatientBuilder_2132();
            director.ConstructPatientAppointment(patientBuilder,"Duygu \n ","Heart Clinic");

            IStaff_2132 patient2 = patientBuilder.GetPatient();
            Console.WriteLine("Patient created: \n " + patient2.Name +"(Department: \n  " + patient2.Department + ")");

            Console.WriteLine();

            Appointment_2132 appointment2 = new Appointment_2132();
            string details2 = appointment.Details();
            Console.WriteLine("Appointment Details: \n " + details2);

            Dispatch_2132 dispatchInfo = dispatchBuilder.GetDispatch();
            Console.WriteLine("Dispatch Info - Name:  \n " + dispatchInfo.Name + "Department: " + dispatchInfo.Department);

            Doctor_2132 doctorInfo = doctorBuilder.GetDoctor();
            Console.WriteLine("Doctor Info - Name:  \n " + doctorInfo.Name + "Department: " + doctorInfo.Department);

            Patient_2132 patientInfo = patientBuilder.GetPatient();
            Console.WriteLine("Patient Info - Name: " + patientInfo.Name + "Department: " + patientInfo.Department);
        }
    }
}
