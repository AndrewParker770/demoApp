using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Azure.WebJobs.Host;
using Andrew.DemoApp.Application.UseCases.Appointments;
using MediatR;
using Serilog.Core;
using Microsoft.Extensions.Logging;
using System.Text.Json.Nodes;
using Newtonsoft.Json;
using Andrew.DemoApp.Application.Contracts.Appointments;

namespace Andrew.DemoApp.Fa
{
    public class AppointmentsHandler(IMediator mediator)
    {
        [FunctionName("AppointmentsHandler")]
        public async Task<NotifyAppointmentsResponse> Run(
            [HttpTrigger(
                AuthorizationLevel.Function,
                "post",
                Route = null)]
            HttpRequestMessage req)
        {
            var requestString = await req.Content.ReadAsStringAsync();
            var appointment = JsonConvert.DeserializeObject<Appointment>(requestString);

            var request = new NotifyAppointmentsRequest(appointment);

            return await mediator.Send(request);
        }
    }
}
