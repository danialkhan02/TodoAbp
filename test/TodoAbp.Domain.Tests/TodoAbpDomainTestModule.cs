using TodoAbp.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace TodoAbp;

[DependsOn(
    typeof(TodoAbpEntityFrameworkCoreTestModule)
    )]
public class TodoAbpDomainTestModule : AbpModule
{

}
