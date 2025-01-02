using Volo.Abp.Modularity;

namespace Alfa5;

public abstract class Alfa5ApplicationTestBase<TStartupModule> : Alfa5TestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
