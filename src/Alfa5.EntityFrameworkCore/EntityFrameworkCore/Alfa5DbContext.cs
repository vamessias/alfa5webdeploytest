using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.MultiTenancy;

namespace Alfa5.EntityFrameworkCore;

[ConnectionStringName("Default")]
public class Alfa5DbContext : Alfa5DbContextBase<Alfa5DbContext>
{
    public Alfa5DbContext(DbContextOptions<Alfa5DbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.SetMultiTenancySide(MultiTenancySides.Both);

        base.OnModelCreating(builder);
    }
}
