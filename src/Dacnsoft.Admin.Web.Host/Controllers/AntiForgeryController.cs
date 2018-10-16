using Microsoft.AspNetCore.Antiforgery;
using Dacnsoft.Admin.Controllers;

namespace Dacnsoft.Admin.Web.Host.Controllers
{
    public class AntiForgeryController : AdminControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
