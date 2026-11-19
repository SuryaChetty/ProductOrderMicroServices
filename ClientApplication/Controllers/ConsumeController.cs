using Microsoft.AspNetCore.Mvc;

namespace ClientApplication.Controllers
{
    public class ConsumeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
