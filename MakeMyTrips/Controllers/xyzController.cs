using Microsoft.AspNetCore.Mvc;

namespace MakeMyTrips.Controllers
{
    public class xyzController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
