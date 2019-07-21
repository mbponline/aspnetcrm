using AspNetCrm.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace AspNetCrm.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(AspNetCrmEntityFrameworkCoreDbMigrationsModule),
        typeof(AspNetCrmApplicationContractsModule)
        )]
    public class AspNetCrmDbMigratorModule : AbpModule
    {
        
    }
}
