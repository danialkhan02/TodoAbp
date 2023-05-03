using System;
using System.Collections.Generic;
using System.Text;
using TodoAbp.Localization;
using Volo.Abp.Application.Services;

namespace TodoAbp;

/* Inherit your application services from this class.
 */
public abstract class TodoAbpAppService : ApplicationService
{
    protected TodoAbpAppService()
    {
        LocalizationResource = typeof(TodoAbpResource);
    }
}
