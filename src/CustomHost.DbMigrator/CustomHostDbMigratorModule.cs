using CustomHost.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace CustomHost.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(CustomHostEntityFrameworkCoreModule),
        typeof(CustomHostApplicationContractsModule)
        )]
    public class CustomHostDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
