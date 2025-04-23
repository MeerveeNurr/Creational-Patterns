using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_2132
{
    internal class AppointmentDirector_2132
    {
        private IAppointmentBuilder_2132 _builder;


        public AppointmentDirector_2132(IAppointmentBuilder_2132 builder)
        {
            _builder = builder;
        }
        public void ConstructDoctorAppointment(IDoctorBuilder_2132 doctorBuilder, string name, string department)
        {
            doctorBuilder.SetName(name);
            doctorBuilder.SetDepartment(department);
           
        }

        public void ConstructPatientAppointment(IPatientBuilder_2132 patientBuilder, string name, string department)
        {
            patientBuilder.SetName(name);
            patientBuilder.SetDepartment(department);
           
        }
        public void ConstructDispatchAppointment(IDispatchBuilder_2132 builder, string name, string department)
        {
            builder.SetName(name);
            builder.SetDepartment(department);
        }

        public void ConstructAppointmentDate(DateTime date)
        {
            _builder.SetDate(date);
        }
        public void ConstructAppointment()
        {
            _builder.Build();
        }
    }
}