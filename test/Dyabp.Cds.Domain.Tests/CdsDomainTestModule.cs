using Dyabp.Cds.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Dyabp.Cds
{
    [DependsOn(
        typeof(CdsEntityFrameworkCoreTestModule)
        )]
    public class CdsDomainTestModule : AbpModule
    {

    }
}