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
            List<Package> agenziaList = new();

            using (AgenziaContext db = new AgenziaContext())
            {
                agenziaList = db.Viaggi.ToList();
            }

            return View(agenziaList);
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            PackageMessage? detailsMessages = new();
            using(AgenziaContext db = new AgenziaContext())
            {
                Package? pacchetto = db.Viaggi.Where(pacchetto => pacchetto.Id == id).FirstOrDefault();
                List<MessageOb> messages = db.Messages.Where(message => message.PackageId==id).ToList();
                detailsMessages.Package = pacchetto;
                detailsMessages.Messages = messages;
            }
            if (detailsMessages != null)
                return View(detailsMessages);
            else
                return NotFound("Non ci sono informazioni riguardo questo pacchetto");
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View(new Package());
        }

        [HttpPost]
        public IActionResult Create(Package data)
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
            Package? viaggioToEdit = null;

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
                Package? viaggio = db.Viaggi.Where(viaggio => viaggio.Id == id).FirstOrDefault();

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
