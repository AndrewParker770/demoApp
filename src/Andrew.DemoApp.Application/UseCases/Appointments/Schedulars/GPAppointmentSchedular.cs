using Andrew.DemoApp.Application.UseCases.Appointments.Patients.SmartEnums;
using Andrew.DemoApp.Application.UseCases.Appointments.Schedulars.Abstractions;
using Microsoft.Extensions.Logging;

namespace Andrew.DemoApp.Application.UseCases.Appointments.Schedulars
{
    public class GPAppointmentSchedular(ILogger<GPAppointmentSchedular> logger) : IAppointmentSchedular
    {
        private readonly ILogger<GPAppointmentSchedular> _logger = logger;
        public bool IsMatch(string appointmentType)
        {
            return appointmentType == "GP";
        }

        Task<NotifyAppointmentsResponse> IAppointmentSchedular.ProcessAsync<TRequest>(TRequest request, CancellationToken cancellationToken)
        {
            var appointmentsRequest = request as NotifyAppointmentsRequest;

            var patientObj = PatientCatagory.getPatientObj(appointmentsRequest.Patient);
            var result = patientObj.ScheduleAppointment(appointmentsRequest.AppointmentType);

            /*
                GP only bevhaviour using specific patient requirements 
            */

            var response = new NotifyAppointmentsResponse { resultString = result };

            return Task.FromResult(response);
        }
    }
}
