using Client.Models.Security;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Client.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(AuthorizationVm authorization)
        {
            //return View("Chat");
            return View("ChatMetanit");
        }

        [HttpGet]
        public IActionResult Chat()
        {
            return View();
        }

    }
}
