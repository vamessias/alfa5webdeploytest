using Volo.Abp.Settings;

namespace Alfa5.Settings;

public class Alfa5SettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(Alfa5Settings.MySetting1));
    }
}
