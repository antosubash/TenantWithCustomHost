using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using CustomHost.Data;
using Volo.Abp.DependencyInjection;

namespace CustomHost.EntityFrameworkCore
{
    public class EntityFrameworkCoreCustomHostDbSchemaMigrator
        : ICustomHostDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreCustomHostDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the CustomHostDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<CustomHostDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}
