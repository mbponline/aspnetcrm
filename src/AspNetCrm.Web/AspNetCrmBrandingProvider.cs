using Volo.Abp.AspNetCore.Mvc.UI.Theme.Shared.Components;
using Volo.Abp.DependencyInjection;

namespace AspNetCrm.Web
{
    [Dependency(ReplaceServices = true)]
    public class AspNetCrmBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "AspNetCrm";
    }
}
