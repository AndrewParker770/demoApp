using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Andrew.DemoApp.Application.UseCases.Appointments.Schedulars.Abstractions;
using MediatR;

namespace Andrew.DemoApp.Application.UseCases.Appointments
{
    public class NotifyAppointmentsRequestHandler(ICollection<IAppointmentSchedular> schedulars)
        : IRequestHandler<NotifyAppointmentsRequest, NotifyAppointmentsResponse>
    {
        private readonly ICollection<IAppointmentSchedular> _schedulars = schedulars;
        async Task<NotifyAppointmentsResponse> IRequestHandler<NotifyAppointmentsRequest, NotifyAppointmentsResponse>.Handle(
            NotifyAppointmentsRequest request,
            CancellationToken cancellationToken)
        {
            var schedular = _schedulars.FirstOrDefault(schedular => schedular.IsMatch(request.AppointmentType))
                ?? throw new NotSupportedException("Unsupported appointment type");

            return await schedular.ProcessAsync(request, cancellationToken);
        }
    }
}
