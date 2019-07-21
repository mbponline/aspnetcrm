using Volo.Abp.Modularity;

namespace AspNetCrm
{
    [DependsOn(
        typeof(AspNetCrmApplicationModule),
        typeof(AspNetCrmDomainTestModule)
        )]
    public class AspNetCrmApplicationTestModule : AbpModule
    {

    }
}