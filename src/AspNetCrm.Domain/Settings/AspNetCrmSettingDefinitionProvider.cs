using Volo.Abp.Settings;

namespace AspNetCrm.Settings
{
    public class AspNetCrmSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(AspNetCrmSettings.MySetting1));
        }
    }
}
