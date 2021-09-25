using CustomHost.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace CustomHost.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class CustomHostController : AbpController
    {
        protected CustomHostController()
        {
            LocalizationResource = typeof(CustomHostResource);
        }
    }
}