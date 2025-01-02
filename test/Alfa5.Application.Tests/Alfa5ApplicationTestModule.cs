using Volo.Abp.Modularity;

namespace Alfa5;

[DependsOn(
    typeof(Alfa5ApplicationModule),
    typeof(Alfa5DomainTestModule)
)]
public class Alfa5ApplicationTestModule : AbpModule
{

}
