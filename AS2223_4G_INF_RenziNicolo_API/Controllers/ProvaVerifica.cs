using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AS2223_4G_INF_RenziNicolo_API.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class ProvaVerifica : Controller
    {
        [HttpGet(Name = "GetPariDispari")]
        public JsonResult GetPariDispari(int numero)
        {
            numero = numero % 2;
            if (numero == 0)
            {
                return Json(new { status = "OK", message = "è pari" });
            }
            else
            {
                return Json(new { status = "OK", message = "è dispari" });
            }
        }

        [HttpGet(Name = "GetFattoriale")]
        public JsonResult GetFattoriale(int fattoriale)
        {
            int res = 1;
            for (int i = 0; i > fattoriale; i++)
            {
                res = res * fattoriale - i;
            }
            return Json(new { output = res ,status = "OK", });
        }
    }
}