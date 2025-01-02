using Alfa5.Books;
using Xunit;

namespace Alfa5.EntityFrameworkCore.Applications.Books;

[Collection(Alfa5TestConsts.CollectionDefinitionName)]
public class EfCoreBookAppService_Tests : BookAppService_Tests<Alfa5EntityFrameworkCoreTestModule>
{

}