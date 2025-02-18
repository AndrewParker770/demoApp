using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Andrew.DemoApp.Application.UseCases.Appointments.Schedulars.Abstractions
{
    interface IAppointmentSchedular
    {
        bool IsMatch(string appointmentType);

        Task ProcessAsync<TRequest>(TRequest request, CancellationToken cancellationToken)
            where TRequest : IAppointmentNotification;
    }
}
