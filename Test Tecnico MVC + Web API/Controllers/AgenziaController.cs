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

        [HttpGet]
        public IActionResult Details(int id)
        {
            using(AgenziaContext db = new AgenziaContext())
            {
                PacchettoViaggio? pacchetto = db.Viaggi.Where(pacchetto => pacchetto.Id == id).FirstOrDefault();
                if (pacchetto != null)
                    return View(pacchetto);
                else
                    return NotFound("Non ci sono informazioni riguardo questo pacchetto");
            }
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View(new PacchettoViaggio());
        }

        [HttpPost]
        public IActionResult Create(PacchettoViaggio data)
        {
            if (!ModelState.IsValid)
            {
                return View("Create", data);
            }

            using(AgenziaContext db = new AgenziaContext())
            {
                db.Viaggi.Add(data);
                db.SaveChanges();
            }

            return RedirectToAction("Index", "Agenzia");
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            PacchettoViaggio? viaggioToEdit = null;

            using(AgenziaContext db = new AgenziaContext())
            {
                viaggioToEdit = db.Viaggi.Where(pacchetto => pacchetto.Id == id).FirstOrDefault();
            }

            if (viaggioToEdit != null)
                return View(viaggioToEdit);
            else
                return NotFound();
        }


        [HttpPost]
        public IActionResult Delete(int id)
        {
            using (AgenziaContext db = new AgenziaContext())
            {
                PacchettoViaggio? viaggio = db.Viaggi.Where(viaggio => viaggio.Id == id).FirstOrDefault();

                if (viaggio != null)
                {
                    db.Viaggi.Remove(viaggio);
                    db.SaveChanges();

                    return RedirectToAction("Index", "Agenzia");
                }
                else
                {
                    return NotFound();
                }
            }
        }
    }
}
