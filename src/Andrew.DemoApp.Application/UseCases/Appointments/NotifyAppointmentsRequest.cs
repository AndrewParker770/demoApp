using Andrew.DemoApp.Application.Contracts.Appointments;
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
    public class NotifyAppointmentsRequest(Appointment appointment) : IAppointmentNotification, IRequest<NotifyAppointmentsResponse>
    {

        public string AppointmentType => appointment.AppointmentType;

        public string RequestType => appointment.RequestType;

        public SmartEnum<PatientCatagory> Patient => appointment.Patient;
    }
}
