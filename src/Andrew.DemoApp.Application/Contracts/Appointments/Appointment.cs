using Andrew.DemoApp.Application.UseCases.Appointments.Patients.SmartEnums;
using Ardalis.SmartEnum.JsonNet;
using Ardalis.SmartEnum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Andrew.DemoApp.Application.Contracts.Appointments
{
    public class Appointment
    {
        public string AppointmentType;

        public string RequestType;

        [JsonConverter(typeof(SmartEnumNameConverter<PatientCatagory, int>))]
        public SmartEnum<PatientCatagory> Patient;
    }
}
