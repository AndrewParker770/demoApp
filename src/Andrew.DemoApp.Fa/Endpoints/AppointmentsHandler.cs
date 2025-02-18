using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Azure.WebJobs.Host;
using Andrew.DemoApp.Application.UseCases.Appointments;
using MediatR;

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
            var request = new NotifyAppointmentsRequest(req);

            return await mediator.Send(request);
        }
    }
}
