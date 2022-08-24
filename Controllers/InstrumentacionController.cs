using Microsoft.AspNetCore.Mvc;

namespace instrumentacionTESCHI.Controllers
{
    public class InstrumentacionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
