using System.Threading.Tasks;

namespace Alfa5.Data;

public interface IAlfa5DbSchemaMigrator
{
    Task MigrateAsync();
}
