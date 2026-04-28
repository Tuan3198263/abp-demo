using EmpManager.Samples;
using Xunit;

namespace EmpManager.EntityFrameworkCore.Domains;

[Collection(EmpManagerTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<EmpManagerEntityFrameworkCoreTestModule>
{

}
