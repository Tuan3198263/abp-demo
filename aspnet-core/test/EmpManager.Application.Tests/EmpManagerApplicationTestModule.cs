using Volo.Abp.Modularity;

namespace EmpManager;

[DependsOn(
    typeof(EmpManagerApplicationModule),
    typeof(EmpManagerDomainTestModule)
)]
public class EmpManagerApplicationTestModule : AbpModule
{

}
