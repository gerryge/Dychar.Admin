using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using Dychar.Admin.Controllers;

namespace Dychar.Admin.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : AdminControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
