using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;
using Volo.Abp.MultiTenancy;

namespace CustomHost.Web
{
    [Dependency(ReplaceServices = true)]
    public class CustomHostBrandingProvider : DefaultBrandingProvider
    {
        private readonly ICurrentTenant _currentTenant;

        public override string AppName => _currentTenant.Name ?? "CustomHost";

        public CustomHostBrandingProvider(ICurrentTenant currentTenant)
        {
            _currentTenant = currentTenant;
        }
    }
}
