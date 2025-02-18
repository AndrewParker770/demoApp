﻿using Andrew.DemoApp.Application.UseCases.Appointments.Schedulars.Abstractions;

namespace Andrew.DemoApp.Application.UseCases.Appointments.Schedulars
{
    public class GPAppointmentSchedular() : IAppointmentSchedular
    {
        //private readonly ILogger<GPAppointmentSchedular> _logger = logger;
        public bool IsMatch(string appointmentType)
        {
            return appointmentType == "GP";
        }

        Task<NotifyAppointmentsResponse> IAppointmentSchedular.ProcessAsync<TRequest>(TRequest request, CancellationToken cancellationToken)
        {
            //_logger.LogInformation("Processing GP Appointment");

            return Task.FromResult(new NotifyAppointmentsResponse());
        }
    }
}
