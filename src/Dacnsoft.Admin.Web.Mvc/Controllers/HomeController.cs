using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using Dacnsoft.Admin.Controllers;

namespace Dacnsoft.Admin.Web.Controllers
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
