using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Alfa5.Data;

/* This is used if database provider does't define
 * IAlfa5DbSchemaMigrator implementation.
 */
public class NullAlfa5DbSchemaMigrator : IAlfa5DbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
