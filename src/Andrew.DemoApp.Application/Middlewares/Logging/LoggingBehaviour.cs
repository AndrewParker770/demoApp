using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Andrew.DemoApp.Application.Middlewares.LoggingBehaviour
{
    internal class LoggingBehaviour<TRequest, TResponse>()
        : IPipelineBehavior<TRequest, TResponse>
    {
        //private readonly ILogger<LoggingBehaviour<TRequest, TResponse>> _logger = logger;
        public async Task<TResponse> Handle(
            TRequest request,
            RequestHandlerDelegate<TResponse> next,
            CancellationToken cancellationToken)
        {
            try
            {
                var requestName = request?.GetType().Name;

                return await next();
            }
            catch
            {
                throw;
            }
        }
    }
}
