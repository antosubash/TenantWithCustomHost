using System;
using System.Collections.Generic;
using System.Text;
using CustomHost.Localization;
using Volo.Abp.Application.Services;

namespace CustomHost
{
    /* Inherit your application services from this class.
     */
    public abstract class CustomHostAppService : ApplicationService
    {
        protected CustomHostAppService()
        {
            LocalizationResource = typeof(CustomHostResource);
        }
    }
}
