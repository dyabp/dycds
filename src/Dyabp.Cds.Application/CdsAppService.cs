using System;
using System.Collections.Generic;
using System.Text;
using Dyabp.Cds.Localization;
using Volo.Abp.Application.Services;

namespace Dyabp.Cds
{
    /* Inherit your application services from this class.
     */
    public abstract class CdsAppService : ApplicationService
    {
        protected CdsAppService()
        {
            LocalizationResource = typeof(CdsResource);
        }
    }
}
