﻿using Microsoft.EntityFrameworkCore;

namespace Dyabp.Cds.EntityFrameworkCore
{
    /* This class is needed for EF Core console commands
     * (like Add-Migration and Update-Database commands) */
    public class CdsDbContextFactory :
        CdsDbContextFactoryBase<CdsDbContext>
    {
        protected override CdsDbContext CreateDbContext(DbContextOptions<CdsDbContext> dbContextOptions)
        {
            return new CdsDbContext(dbContextOptions);
        }
    }
}
