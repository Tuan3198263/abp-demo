using Volo.Abp.Modularity;

namespace EmpManager;

public abstract class EmpManagerApplicationTestBase<TStartupModule> : EmpManagerTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
