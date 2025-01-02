using Microsoft.EntityFrameworkCore;

namespace Alfa5.EntityFrameworkCore;

public class Alfa5DbContextFactory :
    Alfa5DbContextFactoryBase<Alfa5DbContext>
{
    protected override Alfa5DbContext CreateDbContext(
        DbContextOptions<Alfa5DbContext> dbContextOptions)
    {
        return new Alfa5DbContext(dbContextOptions);
    }
}
