using Microsoft.AspNetCore.Mvc;

namespace AS2223_4G_INF_RenziNicolo_API.Controllers
{
    public class ProvaVerifica : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet(Name = "GetNumber")]
        public JsonResult Get(int numero)
        {
            numero = numero % 2;
            if (numero == 0)
            {
                return Json(new { status = "OK", message = "è pari"});
            }
            else
            {
                return Json(new { status = "OK", message = "è dispari" });
            }
        }
    }
}
