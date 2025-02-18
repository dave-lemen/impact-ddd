using Microsoft.Extensions.DependencyInjection;
using Modules.CaseManagers.Application.Facades;

namespace Modules.CaseManagers
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddCaseManagersModule(this IServiceCollection services)
        {
            services.AddScoped<ICaseManagerFacade, CaseManagerFacade>(); // ✅ Works because of InternalsVisibleTo
            return services;
        }
    }
}
