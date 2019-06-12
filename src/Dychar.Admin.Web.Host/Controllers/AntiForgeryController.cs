using Microsoft.AspNetCore.Antiforgery;
using Dychar.Admin.Controllers;

namespace Dychar.Admin.Web.Host.Controllers
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
