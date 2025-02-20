using Andrew.DemoApp.Application.Middlewares.LoggingBehaviour;
using MediatR;
using Microsoft.Extensions.Logging;
using Org.BouncyCastle.Asn1.Esf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Andrew.DemoApp.Application.Middlewares.ExceptionHandling
{
    internal class ExceptionHandlingBehaviour<TRequest, TResponse>(ILogger<ExceptionHandlingBehaviour<TRequest, TResponse>> logger)
        : IPipelineBehavior<TRequest, TResponse>
    {
        private readonly ILogger<ExceptionHandlingBehaviour<TRequest, TResponse>> _logger = logger;

        public async Task<TResponse> Handle(
            TRequest request,
            RequestHandlerDelegate<TResponse> next,
            CancellationToken cancellationToken)
        {
            try
            {
                return await next();
            }
            catch(Exception ex)
            {
                _logger.LogError("Exception caught with message: {exceptionMessage}", ex.Message);

                /*
                    Other exception handling behaviour
                */

                throw;
            }
        }
    }
}
