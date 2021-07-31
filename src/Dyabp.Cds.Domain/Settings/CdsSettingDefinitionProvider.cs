using Volo.Abp.Settings;

namespace Dyabp.Cds.Settings
{
    public class CdsSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(CdsSettings.MySetting1));
        }
    }
}
