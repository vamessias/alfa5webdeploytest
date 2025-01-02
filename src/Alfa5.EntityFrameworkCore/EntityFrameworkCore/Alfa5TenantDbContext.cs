using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.MultiTenancy;

namespace Alfa5.EntityFrameworkCore;

[ConnectionStringName("Default")]
public class Alfa5TenantDbContext : Alfa5DbContextBase<Alfa5TenantDbContext>
{
    public Alfa5TenantDbContext(DbContextOptions<Alfa5TenantDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.SetMultiTenancySide(MultiTenancySides.Tenant);

        base.OnModelCreating(builder);
    }
}
