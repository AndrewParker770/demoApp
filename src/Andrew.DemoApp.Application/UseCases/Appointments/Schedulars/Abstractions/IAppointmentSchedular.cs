using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Andrew.DemoApp.Application.UseCases.Appointments.Schedulars.Abstractions
{
    public interface IAppointmentSchedular
    {
        bool IsMatch(string appointmentType);

        Task<NotifyAppointmentsResponse> ProcessAsync<TRequest>(TRequest request, CancellationToken cancellationToken)
            where TRequest : IAppointmentNotification;
    }
}
