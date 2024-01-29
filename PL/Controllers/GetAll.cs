using Microsoft.AspNetCore.Mvc;

namespace PL.Controllers
{
    public class GetAll : Controller
    {
        public IActionResult Get()
        {
            return View();
        }
    }
}
