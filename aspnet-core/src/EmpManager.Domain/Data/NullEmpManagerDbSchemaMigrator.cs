using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace EmpManager.Data;

/* This is used if database provider does't define
 * IEmpManagerDbSchemaMigrator implementation.
 */
public class NullEmpManagerDbSchemaMigrator : IEmpManagerDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
