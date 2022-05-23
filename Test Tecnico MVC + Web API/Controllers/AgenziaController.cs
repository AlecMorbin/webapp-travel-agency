using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Test_Tecnico_MVC___Web_API.Models;
using Test_Tecnico_MVC___Web_API.Data;

namespace Test_Tecnico_MVC___Web_API.Controllers
{
    public class AgenziaController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            List<PacchettoViaggio> agenziaList = new();

            using (AgenziaContext db = new AgenziaContext())
            {
                agenziaList = db.Viaggi.ToList();
            }
            return View(agenziaList);
        }


    }
}
