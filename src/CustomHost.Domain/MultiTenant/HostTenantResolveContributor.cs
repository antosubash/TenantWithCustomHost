using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.MultiTenancy;

namespace CustomHost.MultiTenant
{
    public class HostTenantResolveContributor : TenantResolveContributorBase
    {
        public override async Task ResolveAsync(ITenantResolveContext context)
        {
            var currentContextAccessor = context.ServiceProvider.GetRequiredService<IHttpContextAccessor>();
            var tenantRepository = context.ServiceProvider.GetRequiredService<ICustomTenantRepository>();

            var host = currentContextAccessor?.HttpContext?.Request.Host.Host;
            if (tenantRepository != null)
            {
                var tenant = await tenantRepository.GetTenantByHost(host);

                if (tenant != null)
                {
                    context.TenantIdOrName = tenant.Name;
                }
            }
        }

        public override string Name => "Host";
    }
}
