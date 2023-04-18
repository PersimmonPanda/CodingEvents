using Microsoft.AspNetCore.Mvc;

namespace CodingEvents.Controllers
{
    public class SomethingNew : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
