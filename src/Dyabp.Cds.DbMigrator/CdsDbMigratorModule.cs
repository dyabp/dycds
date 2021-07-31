using Dyabp.Cds.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace Dyabp.Cds.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(CdsEntityFrameworkCoreModule),
        typeof(CdsApplicationContractsModule)
        )]
    public class CdsDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
