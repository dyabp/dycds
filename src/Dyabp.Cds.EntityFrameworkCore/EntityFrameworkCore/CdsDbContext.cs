﻿using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.MultiTenancy;

namespace Dyabp.Cds.EntityFrameworkCore
{
    [ConnectionStringName("Default")]
    public class CdsDbContext :
       CdsDbContextBase<CdsDbContext>
    {
        public CdsDbContext(DbContextOptions<CdsDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.SetMultiTenancySide(MultiTenancySides.Both);

            base.OnModelCreating(builder);
        }
    }
}
