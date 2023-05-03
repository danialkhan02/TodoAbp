using Volo.Abp.Settings;

namespace TodoAbp.Settings;

public class TodoAbpSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(TodoAbpSettings.MySetting1));
    }
}
