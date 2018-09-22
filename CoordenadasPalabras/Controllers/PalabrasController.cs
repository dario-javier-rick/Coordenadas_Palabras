using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace CoordenadasPalabras.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PalabrasController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "test1", "test2" };
        }

    }
}