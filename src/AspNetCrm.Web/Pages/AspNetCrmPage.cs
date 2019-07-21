using Microsoft.AspNetCore.Mvc.Localization;
using Microsoft.AspNetCore.Mvc.Razor.Internal;
using AspNetCrm.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace AspNetCrm.Web.Pages
{
    /* Inherit your UI Pages from this class. To do that, add this line to your Pages (.cshtml files under the Page folder):
     * @inherits AspNetCrm.Web.Pages.AspNetCrmPage
     */
    public abstract class AspNetCrmPage : AbpPage
    {
        [RazorInject]
        public IHtmlLocalizer<AspNetCrmResource> L { get; set; }
    }
}
