using Andrew.DemoApp.Application.UseCases.Appointments.Patients.SmartEnums;
using Andrew.DemoApp.Application.UseCases.Appointments.Schedulars.Abstractions;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Andrew.DemoApp.Application.UseCases.Appointments.Schedulars
{
    public class PhysioAppointmentSchedular(ILogger<PhysioAppointmentSchedular> logger) : IAppointmentSchedular
    {
        private readonly ILogger<PhysioAppointmentSchedular> _logger = logger;
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
                Physio only bevhaviour using specific patient requirements 
            */

            var response = new NotifyAppointmentsResponse { resultString = result };

            return Task.FromResult(response);
        }
    }
}
