using Volo.Abp.Settings;

namespace CustomHost.Settings
{
    public class CustomHostSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(CustomHostSettings.MySetting1));
        }
    }
}
