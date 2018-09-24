using System;
using CoordenadasPalabras.BLL;
using CoordenadasPalabras.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CoordenadasPalabras.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PalabrasController : ControllerBase
    {
        private string[] secuencias = { "AGVNFT", "XJILSB", "CHAOHD", "ERCVTQ", "ASOYAO", "ERMYUA", "TELEFE" };

        [HttpGet]
        [Route("GetPosiciones")]
        public ActionResult<int[,]> GetPosiciones(string palabra)
        {
            //using (CrucigramaContext db = new CrucigramaContext(null))
            //{
            //    db.Logs.Add(new Log
            //    {
            //        Fecha = DateTime.Now,
            //        Thread = "",
            //        Level = "INFO",
            //        Logger = "",
            //        SessionId = "",
            //        Message = "",
            //        Exception = null
            //    });

            //    db.SaveChangesAsync();
            //}

            secuencias.ConfigurarEstrategiaBusqueda(new EstrategiaBusqueda());
            var resultado = secuencias.Buscar(palabra);
            return resultado;
        }

    }
}