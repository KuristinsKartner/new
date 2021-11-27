using Client.Models.Chat;
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

            var model = new ChatVm()
            {
                UserName = authorization.Name
            };

            return View("Chat", model);
        }

        [HttpPost]
        public IActionResult Chat(ChatVm model)
        {
            return View(model);
        }

    }
}
