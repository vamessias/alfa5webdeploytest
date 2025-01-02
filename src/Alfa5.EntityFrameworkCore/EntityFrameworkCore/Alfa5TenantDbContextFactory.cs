using Microsoft.EntityFrameworkCore;

namespace Alfa5.EntityFrameworkCore;

public class Alfa5TenantDbContextFactory :
    Alfa5DbContextFactoryBase<Alfa5TenantDbContext>
{
    protected override Alfa5TenantDbContext CreateDbContext(
        DbContextOptions<Alfa5TenantDbContext> dbContextOptions)
    {
        return new Alfa5TenantDbContext(dbContextOptions);
    }
}
