using System;
using System.Collections.Generic;
using System.Text;
using AspNetCrm.Localization;
using Volo.Abp.Application.Services;

namespace AspNetCrm
{
    /* Inherit your application services from this class.
     */
    public abstract class AspNetCrmAppService : ApplicationService
    {
        protected AspNetCrmAppService()
        {
            LocalizationResource = typeof(AspNetCrmResource);
        }
    }
}
