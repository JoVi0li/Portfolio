using Microsoft.AspNetCore.Mvc;

namespace Portfolio.Controllers
{
    public class SobreController : Controller
    {

        [Route("Sobre")]
        public IActionResult Sobre()
        {
            return View();
        }

        
    }
}