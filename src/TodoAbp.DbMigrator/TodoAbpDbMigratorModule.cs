using TodoAbp.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace TodoAbp.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(TodoAbpEntityFrameworkCoreModule),
    typeof(TodoAbpApplicationContractsModule)
    )]
public class TodoAbpDbMigratorModule : AbpModule
{

}
