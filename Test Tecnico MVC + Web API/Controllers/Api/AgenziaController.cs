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
        public IActionResult Get()
        {
            List<PacchettoViaggio> listaViaggi = new();

            using (AgenziaContext db= new AgenziaContext())
            {
                listaViaggi = db.Viaggi.ToList<PacchettoViaggio>();
            }
            return Ok(listaViaggi);
        }
    }
}
