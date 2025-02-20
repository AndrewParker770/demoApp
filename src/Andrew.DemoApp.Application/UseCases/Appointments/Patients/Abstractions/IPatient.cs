using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Andrew.DemoApp.Application.UseCases.Appointments.Patients.Abstractions
{
    public interface IPatient
    {
        public string ScheduleAppointment(string appointmentType);
    }
}
