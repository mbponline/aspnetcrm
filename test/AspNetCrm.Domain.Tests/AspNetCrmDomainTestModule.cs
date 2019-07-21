using AspNetCrm.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace AspNetCrm
{
    [DependsOn(
        typeof(AspNetCrmEntityFrameworkCoreTestModule)
        )]
    public class AspNetCrmDomainTestModule : AbpModule
    {

    }
}