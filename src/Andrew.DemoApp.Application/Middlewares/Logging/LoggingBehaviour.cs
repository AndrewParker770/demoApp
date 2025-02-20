using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Andrew.DemoApp.Application.Middlewares.LoggingBehaviour
{
    internal class LoggingBehaviour<TRequest, TResponse>(ILogger<LoggingBehaviour<TRequest, TResponse>> logger)
        : IPipelineBehavior<TRequest, TResponse>
    {
        private readonly ILogger<LoggingBehaviour<TRequest, TResponse>> _logger = logger;
        public async Task<TResponse> Handle(
            TRequest request,
            RequestHandlerDelegate<TResponse> next,
            CancellationToken cancellationToken)
        {
            try
            {
                var requestName = request?.GetType().Name;

                _logger.LogInformation("Recieved request of type {requestName}... Payload: {@request}", requestName, request);

                var response = await next();

                _logger.LogInformation("Recieved request of type {requestName} has been processed", requestName);

                return response;
            }
            catch
            {
                throw;
            }
        }
    }
}
