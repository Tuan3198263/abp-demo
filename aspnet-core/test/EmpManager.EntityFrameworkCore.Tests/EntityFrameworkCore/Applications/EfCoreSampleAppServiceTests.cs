using EmpManager.Samples;
using Xunit;

namespace EmpManager.EntityFrameworkCore.Applications;

[Collection(EmpManagerTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<EmpManagerEntityFrameworkCoreTestModule>
{

}
