using Andrew.DemoApp.Application.UseCases.Appointments.Patients.Abstractions;
using Microsoft.Extensions.Logging;

namespace Andrew.DemoApp.Application.UseCases.Appointments.Patients
{
    public class AbleBodiedPatient() : IPatient
    {
        public string scheduleAppointment()
        {
            return "Booking appointment for able bodied patient...";
        }
    }
}
