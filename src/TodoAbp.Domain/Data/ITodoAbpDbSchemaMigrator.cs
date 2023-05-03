using System.Threading.Tasks;

namespace TodoAbp.Data;

public interface ITodoAbpDbSchemaMigrator
{
    Task MigrateAsync();
}
