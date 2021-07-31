using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Dyabp.Cds.Data;
using Volo.Abp.DependencyInjection;

namespace Dyabp.Cds.EntityFrameworkCore
{
    public class EntityFrameworkCoreCdsDbSchemaMigrator
        : ICdsDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreCdsDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the CdsDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<CdsDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}
