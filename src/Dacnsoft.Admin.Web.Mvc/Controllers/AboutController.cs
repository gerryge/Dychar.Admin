using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using Dacnsoft.Admin.Controllers;

namespace Dacnsoft.Admin.Web.Controllers
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
