using Andrew.DemoApp.Application.Middlewares.ExceptionHandling;
using Andrew.DemoApp.Application.Middlewares.LoggingBehaviour;
using Andrew.DemoApp.Application.UseCases.Appointments;
using Andrew.DemoApp.Application.UseCases.Appointments.Schedulars;
using Andrew.DemoApp.Application.UseCases.Appointments.Schedulars.Abstractions;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Andrew.DemoApp.Application
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            AddMediatR(services);

            AddApplicationServices(services);

            return services;
        }

        private static IServiceCollection AddApplicationServices(IServiceCollection services)
        {
            services.AddScoped<IAppointmentSchedular, GPAppointmentSchedular>();
            services.AddScoped<IAppointmentSchedular, PhysioAppointmentSchedular>();

            return services;
        }

        private static void AddMediatR(IServiceCollection services)
        {
            services.AddMediatR(config =>
                    config.RegisterServicesFromAssembly(typeof(NotifyAppointmentsRequestHandler).GetTypeInfo().Assembly)
                    );

            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ExceptionHandlingBehaviour<,>));
            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(LoggingBehaviour<,>));
        }
    }
}
