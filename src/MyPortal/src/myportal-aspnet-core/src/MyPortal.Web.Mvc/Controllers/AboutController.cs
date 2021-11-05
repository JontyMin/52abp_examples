using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using MyPortal.Controllers;

namespace MyPortal.Web.Controllers
{
    [AbpMvcAuthorize]
    public class AboutController : MyPortalControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
