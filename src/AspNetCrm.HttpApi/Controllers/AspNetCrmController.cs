using AspNetCrm.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace AspNetCrm.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class AspNetCrmController : AbpController
    {
        protected AspNetCrmController()
        {
            LocalizationResource = typeof(AspNetCrmResource);
        }
    }
}