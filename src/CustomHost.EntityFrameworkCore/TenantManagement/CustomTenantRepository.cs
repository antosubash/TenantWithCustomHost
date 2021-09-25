using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using CustomHost.MultiTenant;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.TenantManagement;
using Volo.Abp.TenantManagement.EntityFrameworkCore;

namespace CustomHost.TenantManagement
{
    public class CustomTenantRepository : EfCoreRepository<TenantManagementDbContext, Tenant, Guid>, ICustomTenantRepository
    {
        public CustomTenantRepository(IDbContextProvider<TenantManagementDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }

        public async Task<Tenant> GetTenantByHost(string host, CancellationToken cancellationToken = default)
        {
            var context = await GetDbContextAsync();
            var tenant = context.Tenants.Where(u => EF.Property<string>(u, "Host") == host);
            return await tenant.FirstOrDefaultAsync(cancellationToken: cancellationToken);
        }
    }
}
