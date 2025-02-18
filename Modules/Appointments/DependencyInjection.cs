using Microsoft.Extensions.DependencyInjection;
using Modules.Appointments.Application.Facades;

namespace Modules.Appointments
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddAppointmentsModule(this IServiceCollection services)
        {
            services.AddScoped<IAppointmentFacade, AppointmentFacade>(); // ✅ Works because of InternalsVisibleTo
            return services;
        }
    }
}
