using TodoAbp.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace TodoAbp.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class TodoAbpController : AbpControllerBase
{
    protected TodoAbpController()
    {
        LocalizationResource = typeof(TodoAbpResource);
    }
}
