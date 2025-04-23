using System;

namespace DependencyInjection_2132
{
    public class DependecyInjection_2132
    {
        private readonly IDoctor_2132 _doctorService;
        private readonly IPatient_2132 _patientService;
        private readonly IAppointment_2132 _appointmentService;
        private readonly IPoliclinic_2132 _poliklinikService;

        public DependecyInjection_2132(IDoctor_2132 doctorService, IPatient_2132 patientService, IAppointment_2132 appointmentService, IPoliclinic_2132 poliklinikService)
        {
            _doctorService = doctorService;
            _patientService = patientService;
            _appointmentService = appointmentService;
            _poliklinikService = poliklinikService;
        }

        public void AddDoctor(string doctorName)
        {
            _doctorService.AddDoctor(doctorName);
        }

        public void RemoveDoctor(string doctorName)
        {
            _doctorService.RemoveDoctor(doctorName);
        }

        public void AddPatient(string name, string surname, int age)
        {
            _patientService.AddPatient(name, surname, age);
        }

        public void RemovePatient(string name, string surname, int age)
        {
            _patientService.RemovePatient(name, surname, age);
        }

        public void CreateAppointment(string doctorName, string patientName, DateTime date, string polyclinic)
        {
            _appointmentService.CreateAppointment(doctorName, patientName, date, polyclinic);
        }

        public void DeleteAppointment(string doctorName, string patientName, DateTime date)
        {
            _appointmentService.DeleteAppointment(doctorName, patientName, date);
        }

        public void AddPoliklinik(string poliklinikName)
        {
            _poliklinikService.AddPoliklinik(poliklinikName);
        }

        public void RemovePoliklinik(string poliklinikName)
        {
            _poliklinikService.RemovePoliklinik(poliklinikName);
        }
    }
}
