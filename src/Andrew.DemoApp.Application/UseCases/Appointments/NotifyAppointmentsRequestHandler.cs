using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace Andrew.DemoApp.Application.UseCases.Appointments
{
    public class NotifyAppointmentsRequestHandler() : IRequestHandler<NotifyAppointmentsRequest, NotifyAppointmentsResponse>
    {
        async Task<NotifyAppointmentsResponse> IRequestHandler<NotifyAppointmentsRequest, NotifyAppointmentsResponse>.Handle(NotifyAppointmentsRequest request, CancellationToken cancellationToken)
        {
            return await new NotifyAppointmentsResponse();
        }
    }
}
