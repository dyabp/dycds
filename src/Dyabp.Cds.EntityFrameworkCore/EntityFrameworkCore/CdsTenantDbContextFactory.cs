using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Dyabp.Cds.EntityFrameworkCore
{
    /* This class is needed for EF Core console commands
     * (like Add-Migration and Update-Database commands) */
    public class CdsTenantDbContextFactory :
        CdsDbContextFactoryBase<CdsDbContext>
    {
        protected override CdsDbContext CreateDbContext(DbContextOptions<CdsDbContext> dbContextOptions)
        {
            return new CdsDbContext(dbContextOptions);
        }
    }
}
