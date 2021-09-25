using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace CustomHost.Web
{
    [Dependency(ReplaceServices = true)]
    public class CustomHostBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "CustomHost";
    }
}
