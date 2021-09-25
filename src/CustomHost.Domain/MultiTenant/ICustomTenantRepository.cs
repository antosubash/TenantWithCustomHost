using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.TenantManagement;

namespace CustomHost.MultiTenant
{
    public interface ICustomTenantRepository : IBasicRepository<Tenant, Guid>
    {
        Task<Tenant> GetTenantByHost(string host, CancellationToken cancellationToken = default);
    }
}
