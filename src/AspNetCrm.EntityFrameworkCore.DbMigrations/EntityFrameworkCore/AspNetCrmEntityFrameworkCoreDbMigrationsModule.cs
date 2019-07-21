using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace AspNetCrm.EntityFrameworkCore
{
    [DependsOn(
        typeof(AspNetCrmEntityFrameworkCoreModule)
        )]
    public class AspNetCrmEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<AspNetCrmMigrationsDbContext>();
        }
    }
}
