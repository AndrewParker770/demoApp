using Andrew.DemoApp.Application.UseCases.Appointments.Schedulars.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Andrew.DemoApp.Application.UseCases.Appointments.Schedulars
{
    public class PhysioAppointmentSchedular() : IAppointmentSchedular
    {
        //private readonly ILogger<PhysioAppointmentSchedular> _logger = logger;
        public bool IsMatch(string appointmentType)
        {
            return appointmentType == "Physio";
        }

        Task<NotifyAppointmentsResponse> IAppointmentSchedular.ProcessAsync<TRequest>(TRequest request, CancellationToken cancellationToken)
        {
            //_logger.LogInformation("Processing Physio Appointment");

            return Task.FromResult(new NotifyAppointmentsResponse());
        }
    }
}
