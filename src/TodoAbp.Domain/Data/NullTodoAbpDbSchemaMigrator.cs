using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace TodoAbp.Data;

/* This is used if database provider does't define
 * ITodoAbpDbSchemaMigrator implementation.
 */
public class NullTodoAbpDbSchemaMigrator : ITodoAbpDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
