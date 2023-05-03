using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace TodoAbp.Web;

[Dependency(ReplaceServices = true)]
public class TodoAbpBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "TodoAbp";
}
