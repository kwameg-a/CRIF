using Microsoft.Extensions.DependencyInjection;
using WritersLtd.API.Services;

namespace WritersLtd.API.Extensions
{
    public static class ScopedServicesExtension
    {
        public static void AddScopedServices(this IServiceCollection services)
        {
            services.AddScoped<IGetNovelsService, GetNovelsService>();
            services.AddScoped<IGetNovelByIdService, GetNovelByIdService>();
            services.AddScoped<IAddNovelService, AddNovelService>();
        }
    }
}
