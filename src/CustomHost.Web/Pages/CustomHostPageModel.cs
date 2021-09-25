using CustomHost.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace CustomHost.Web.Pages
{
    /* Inherit your PageModel classes from this class.
     */
    public abstract class CustomHostPageModel : AbpPageModel
    {
        protected CustomHostPageModel()
        {
            LocalizationResourceType = typeof(CustomHostResource);
        }
    }
}