using Volo.Abp.Modularity;

namespace Alfa5;

[DependsOn(
    typeof(Alfa5DomainModule),
    typeof(Alfa5TestBaseModule)
)]
public class Alfa5DomainTestModule : AbpModule
{

}
