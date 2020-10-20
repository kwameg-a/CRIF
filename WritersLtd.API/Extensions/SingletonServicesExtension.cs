using Microsoft.Extensions.DependencyInjection;
using WritersLtd.API.Infrastructure.Data;
using WritersLtd.API.Security;

namespace WritersLtd.API.Extensions
{
    public static class SingletonServicesExtension
    {
        public static void AddSingletonServices(this IServiceCollection services)
        {
            services.AddSingleton<IWritersLtdFillingSystem, WritersLtdFillingSystem>();
            services.AddSingleton<ICustomDataProtection, CustomDataProtection>();

        }
    }
}
