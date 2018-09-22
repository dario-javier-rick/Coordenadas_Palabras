using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoordenadasPalabras.BLL;
using CoordenadasPalabras.Models;
using Microsoft.AspNetCore.Mvc;


namespace CoordenadasPalabras.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LogsController: ControllerBase
    {
        [HttpGet]
        [Route("GetLogs")]
        public ActionResult<List<Log>> GetLogs()
        {
            using (CrucigramaContext db = new CrucigramaContext(null))
            {
                return db.Logs.ToList();
            }
        }
    }
}
