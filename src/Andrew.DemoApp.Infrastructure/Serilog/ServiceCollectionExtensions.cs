﻿using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Serilog;
using Serilog.Extensions.Logging;

namespace Andrew.DemoApp.Infrastructure.Serilog
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddSerilog(this IServiceCollection services)
        {
            services.AddSingleton<ILoggerProvider>((sp) =>
            {
                Log.Logger = new LoggerConfiguration()
                    .MinimumLevel.Information()
                    .Enrich.WithProperty("ApplicationName", "Andrew.DemoApp")
                    .CreateLogger();

                return new SerilogLoggerProvider(Log.Logger, true);
            });

            return services;
        }
    }
}
