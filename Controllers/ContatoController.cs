using Microsoft.AspNetCore.Mvc;

namespace Portfolio.Controllers
{
    public class ContatoController : Controller
    {
        [Route("Contato")]
        public IActionResult Contato()
        {
            return View();
        }
    }
}