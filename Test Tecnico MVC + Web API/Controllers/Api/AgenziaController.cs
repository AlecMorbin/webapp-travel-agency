using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Test_Tecnico_MVC___Web_API.Models;
using Test_Tecnico_MVC___Web_API.Data;


namespace Test_Tecnico_MVC___Web_API.Controllers.Api
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AgenziaController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get(string? search)
        {
            List<Package> listaViaggi = new();

            using (AgenziaContext db= new AgenziaContext())
            {
                if(!String.IsNullOrEmpty(search))
                {
                    listaViaggi = db.Viaggi.Where(viaggio => viaggio.Name.Contains(search) ||
                                                    viaggio.Description.Contains(search) ||
                                                    viaggio.Destination.Contains(search)).ToList<Package>();
                }
                else
                {
                    listaViaggi = db.Viaggi.ToList<Package>();
                }
            }
            return Ok(listaViaggi);
        }

        [HttpPost]
        public IActionResult Message(MessageOb message)
        {
            if (ModelState.IsValid)
            {
                using (AgenziaContext db = new AgenziaContext())
                {
                    List<Package> viaggi = db.Viaggi.Where(viaggio => viaggio.Id==message.PackageId).ToList<Package>();
                    List<MessageOb> messages = db.Messages.ToList();
                    if(viaggi.Count == 1)
                    {
                        message.Package=viaggi[0];
                        message.DateTime=DateTime.Now;
                    }

                    if(message.Package!=null)
                    {
                        db.Add(message);
                        db.SaveChanges();
                    }
                }

                return Ok("Message received");
            }
            else
            {
                return BadRequest("Model not correct");
            }
        }
    }
}
