using Volo.Abp.Modularity;

namespace EmpManager;

/* Inherit from this class for your domain layer tests. */
public abstract class EmpManagerDomainTestBase<TStartupModule> : EmpManagerTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
