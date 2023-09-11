using Microsoft.AspNetCore.Mvc;

namespace EastStore.Controllers
{
    public class ItemController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
