using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AS2223_4G_INF_RenziNicolo_API.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class ProvaVerifica : Controller
    {
      

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