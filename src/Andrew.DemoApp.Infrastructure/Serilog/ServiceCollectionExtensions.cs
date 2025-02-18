using Microsoft.Extensions.DependencyInjection;
using Serilog;

namespace Andrew.DemoApp.Infrastructure.Serilog
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddSerilog(this IServiceCollection services)
        {
            //services.AddSingleton<ILoggerProvider>((sp) =>
            //{
            //    Log.Logger = new LoggerConfiguration()
            //        .MinimumLevel.Information()
            //        .Enrich.WithProperty("ApplicationName", "Andrew.DemoApp")
            //        .CreateLogger();

            //    return new SerilogLoggerProvider(Log.Logger, true);
            //});

            return services;
        }
    }
}
