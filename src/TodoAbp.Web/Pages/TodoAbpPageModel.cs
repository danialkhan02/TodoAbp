using TodoAbp.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace TodoAbp.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class TodoAbpPageModel : AbpPageModel
{
    protected TodoAbpPageModel()
    {
        LocalizationResourceType = typeof(TodoAbpResource);
    }
}
