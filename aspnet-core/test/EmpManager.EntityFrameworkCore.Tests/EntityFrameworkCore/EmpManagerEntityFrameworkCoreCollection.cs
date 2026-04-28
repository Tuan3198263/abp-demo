using Xunit;

namespace EmpManager.EntityFrameworkCore;

[CollectionDefinition(EmpManagerTestConsts.CollectionDefinitionName)]
public class EmpManagerEntityFrameworkCoreCollection : ICollectionFixture<EmpManagerEntityFrameworkCoreFixture>
{

}
