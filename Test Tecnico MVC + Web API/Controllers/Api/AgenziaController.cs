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
            List<PacchettoViaggio> listaViaggi = new();

            using (AgenziaContext db= new AgenziaContext())
            {
                if(!String.IsNullOrEmpty(search))
                {
                    listaViaggi = db.Viaggi.Where(viaggio => viaggio.Name.Contains(search) ||
                                                    viaggio.Description.Contains(search) ||
                                                    viaggio.Destination.Contains(search)).ToList<PacchettoViaggio>();
                }
                else
                {
                    listaViaggi = db.Viaggi.ToList<PacchettoViaggio>();
                }
            }
            return Ok(listaViaggi);
        }
    }
}
