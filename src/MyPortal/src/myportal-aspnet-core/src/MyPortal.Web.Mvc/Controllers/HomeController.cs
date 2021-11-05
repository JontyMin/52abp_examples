using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using MyPortal.Controllers;

namespace MyPortal.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : MyPortalControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
