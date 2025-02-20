using Andrew.DemoApp.Application.UseCases.Appointments.Patients.SmartEnums;
using Andrew.DemoApp.Application.UseCases.Appointments.Schedulars.Abstractions;
using Ardalis.SmartEnum;
using Ardalis.SmartEnum.JsonNet;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Andrew.DemoApp.Application.UseCases.Appointments
{
    public class NotifyAppointmentsRequest(HttpRequestMessage request) : BaseRequest(request), IAppointmentNotification, IRequest<NotifyAppointmentsResponse>
    {
        public string AppointmentType => "GP";

        public string RequestType => "";

        [JsonConverter(typeof(SmartEnumNameConverter<PatientCatagory, int>))]
        public SmartEnum<PatientCatagory> Patient;
    }
}
