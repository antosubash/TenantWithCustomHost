using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace CustomHost.Data
{
    /* This is used if database provider does't define
     * ICustomHostDbSchemaMigrator implementation.
     */
    public class NullCustomHostDbSchemaMigrator : ICustomHostDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}