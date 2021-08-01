using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.MultiTenancy;

namespace Dyabp.Cds.EntityFrameworkCore
{
    [ConnectionStringName("Default")]
    public class CdsTenantDbContext :
       CdsDbContextBase<CdsTenantDbContext>
    {
        public CdsTenantDbContext(DbContextOptions<CdsTenantDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.SetMultiTenancySide(MultiTenancySides.Tenant);

            base.OnModelCreating(builder);
        }
    }
}
