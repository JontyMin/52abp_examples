using Abp.AspNetCore.Mvc.ViewComponents;

namespace MyPortal.Web.Views
{
    public abstract class MyPortalViewComponent : AbpViewComponent
    {
        protected MyPortalViewComponent()
        {
            LocalizationSourceName = MyPortalConsts.LocalizationSourceName;
        }
    }
}
