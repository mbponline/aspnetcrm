using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace AspNetCrm.HttpApi.Client.ConsoleTestApp
{
    [DependsOn(
        typeof(AspNetCrmHttpApiClientModule),
        typeof(AbpHttpClientIdentityModelModule)
        )]
    public class AspNetCrmConsoleApiClientModule : AbpModule
    {
        
    }
}
