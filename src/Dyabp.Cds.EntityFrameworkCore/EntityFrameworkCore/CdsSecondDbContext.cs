using Microsoft.EntityFrameworkCore;
using Volo.Abp.AuditLogging.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.PermissionManagement.EntityFrameworkCore;
using Volo.Abp.SettingManagement.EntityFrameworkCore;

namespace Dyabp.Cds.EntityFrameworkCore
{
    [ConnectionStringName("AbpPermissionManagement")]
    public class CdsSecondDbContext : AbpDbContext<CdsSecondDbContext>
    {      
        public CdsSecondDbContext(
            DbContextOptions<CdsSecondDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            /* Include modules to your migration db context */
            modelBuilder.ConfigurePermissionManagement();
            modelBuilder.ConfigureSettingManagement();
            modelBuilder.ConfigureAuditLogging();
        }
    }
}
