using Andrew.DemoApp.Application.UseCases.Appointments.Schedulars.Abstractions;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Andrew.DemoApp.Application.UseCases.Appointments
{
    public class NotifyAppointmentsRequest(HttpRequestMessage request) : BaseRequest(request), IAppointmentNotification, IRequest<NotifyAppointmentsResponse>
    {
        public string AppointmentType => "GP";

        public string RequestType => "";
    }
}
