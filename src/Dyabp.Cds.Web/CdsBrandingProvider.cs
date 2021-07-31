using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace Dyabp.Cds.Web
{
    [Dependency(ReplaceServices = true)]
    public class CdsBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "Cds";
    }
}
