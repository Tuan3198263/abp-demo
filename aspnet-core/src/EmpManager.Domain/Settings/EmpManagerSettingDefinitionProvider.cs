using Volo.Abp.Settings;

namespace EmpManager.Settings;

public class EmpManagerSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(EmpManagerSettings.MySetting1));
    }
}
