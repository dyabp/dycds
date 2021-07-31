using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Dyabp.Cds.Data
{
    /* This is used if database provider does't define
     * ICdsDbSchemaMigrator implementation.
     */
    public class NullCdsDbSchemaMigrator : ICdsDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}