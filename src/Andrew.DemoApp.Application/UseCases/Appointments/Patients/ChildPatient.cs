using Andrew.DemoApp.Application.UseCases.Appointments.Patients.Abstractions;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Andrew.DemoApp.Application.UseCases.Appointments.Patients
{
    public class ChildPatient() : VulnerablePatient
    {
        public override string ScheduleAppointment(string appointmentType)
        {
            return $"Booking {appointmentType} appointment for child patient...";
        }

    }
}
