using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;
using Microsoft.AspNetCore.Mvc.Razor.Internal;

namespace MyPortal.Web.Views
{
    public abstract class MyPortalRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected MyPortalRazorPage()
        {
            LocalizationSourceName = MyPortalConsts.LocalizationSourceName;
        }
    }
}
