using Volo.Abp.Modularity;

namespace CustomHost
{
    [DependsOn(
        typeof(CustomHostApplicationModule),
        typeof(CustomHostDomainTestModule)
        )]
    public class CustomHostApplicationTestModule : AbpModule
    {

    }
}