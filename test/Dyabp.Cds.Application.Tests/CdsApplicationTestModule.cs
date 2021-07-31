using Volo.Abp.Modularity;

namespace Dyabp.Cds
{
    [DependsOn(
        typeof(CdsApplicationModule),
        typeof(CdsDomainTestModule)
        )]
    public class CdsApplicationTestModule : AbpModule
    {

    }
}