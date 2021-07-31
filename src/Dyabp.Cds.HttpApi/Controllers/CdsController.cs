using Dyabp.Cds.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Dyabp.Cds.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class CdsController : AbpController
    {
        protected CdsController()
        {
            LocalizationResource = typeof(CdsResource);
        }
    }
}