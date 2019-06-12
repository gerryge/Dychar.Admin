using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using Dychar.Admin.Controllers;

namespace Dychar.Admin.Web.Controllers
{
    [AbpMvcAuthorize]
    public class AboutController : AdminControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
