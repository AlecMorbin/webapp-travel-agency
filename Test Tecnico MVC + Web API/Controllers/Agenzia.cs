using Microsoft.AspNetCore.Mvc;

namespace Test_Tecnico_MVC___Web_API.Controllers
{
    public class Agenzia : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
    }
}
