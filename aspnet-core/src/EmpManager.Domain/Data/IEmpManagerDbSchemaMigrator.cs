using System.Threading.Tasks;

namespace EmpManager.Data;

public interface IEmpManagerDbSchemaMigrator
{
    Task MigrateAsync();
}
