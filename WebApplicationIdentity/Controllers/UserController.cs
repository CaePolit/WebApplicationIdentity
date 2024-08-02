using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebApplicationIdentity.Controllers
{
    [Authorize]
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]

        public IEnumerable<string> Get()

        {

            return new string[] { "Le One Piece est..", "... Au milieu de l'ocean Pacific" };

        }
    }
}
