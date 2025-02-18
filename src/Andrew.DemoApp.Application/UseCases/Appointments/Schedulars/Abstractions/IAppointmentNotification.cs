using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Andrew.DemoApp.Application.UseCases.Appointments.Schedulars.Abstractions
{
    interface IAppointmentNotification
    {
        public string AppointmentType { get;  }

        public string RequestType { get;  }
    }
}
