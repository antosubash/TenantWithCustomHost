using CustomHost.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace CustomHost
{
    [DependsOn(
        typeof(CustomHostEntityFrameworkCoreTestModule)
        )]
    public class CustomHostDomainTestModule : AbpModule
    {

    }
}