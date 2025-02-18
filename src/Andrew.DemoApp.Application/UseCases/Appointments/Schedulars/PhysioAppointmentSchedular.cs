using Andrew.DemoApp.Application.UseCases.Appointments.Schedulars.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Andrew.DemoApp.Application.UseCases.Appointments.Schedulars
{
    public class PhysioAppointmentSchedular : IAppointmentSchedular
    {
        public bool IsMatch(string appointmentType)
        {
            throw new NotImplementedException();
        }

        Task IAppointmentSchedular.ProcessAsync<TRequest>(TRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
