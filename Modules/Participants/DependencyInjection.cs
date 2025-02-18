using Microsoft.Extensions.DependencyInjection;
using Modules.Participants.Application.Facades;

namespace Modules.Participants
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddCaseManagersModule(this IServiceCollection services)
        {
            services.AddScoped<IParticipantFacade, ParticipantFacade>(); // ✅ Works because of InternalsVisibleTo
            return services;
        }
    }
}