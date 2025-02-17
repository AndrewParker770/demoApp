using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Azure.WebJobs.Host;

namespace Andrew.DemoApp.Fa
{
    public class AppointmentsHandler
    {
        [FunctionName("AppointmentsHandler")]
        public async Task<HttpResponseMessage> Run(
            [HttpTrigger(
                AuthorizationLevel.Function,
                "get",
                "post",
                Route = null)]
            HttpRequestMessage req)
        {
            return null;
        }
    }
}
