using Volo.Abp.Modularity;

namespace EmpManager;

[DependsOn(
    typeof(EmpManagerDomainModule),
    typeof(EmpManagerTestBaseModule)
)]
public class EmpManagerDomainTestModule : AbpModule
{

}
