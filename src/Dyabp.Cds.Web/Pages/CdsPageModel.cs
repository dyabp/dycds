using Dyabp.Cds.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Dyabp.Cds.Web.Pages
{
    /* Inherit your PageModel classes from this class.
     */
    public abstract class CdsPageModel : AbpPageModel
    {
        protected CdsPageModel()
        {
            LocalizationResourceType = typeof(CdsResource);
        }
    }
}