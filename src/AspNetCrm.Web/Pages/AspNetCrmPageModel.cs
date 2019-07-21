using AspNetCrm.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace AspNetCrm.Web.Pages
{
    /* Inherit your PageModel classes from this class.
     */
    public abstract class AspNetCrmPageModel : AbpPageModel
    {
        protected AspNetCrmPageModel()
        {
            LocalizationResourceType = typeof(AspNetCrmResource);
        }
    }
}