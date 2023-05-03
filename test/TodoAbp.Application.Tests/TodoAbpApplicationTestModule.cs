using Volo.Abp.Modularity;

namespace TodoAbp;

[DependsOn(
    typeof(TodoAbpApplicationModule),
    typeof(TodoAbpDomainTestModule)
    )]
public class TodoAbpApplicationTestModule : AbpModule
{

}
