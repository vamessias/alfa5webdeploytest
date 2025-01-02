using Volo.Abp.Modularity;

namespace Alfa5;

/* Inherit from this class for your domain layer tests. */
public abstract class Alfa5DomainTestBase<TStartupModule> : Alfa5TestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
