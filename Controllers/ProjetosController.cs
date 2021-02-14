using Microsoft.AspNetCore.Mvc;

namespace Portfolio.Controllers
{
    public class ProjetosController : Controller
    {
        [Route("Projetos")]
        public IActionResult Projetos()
        {
            return View();
        }

    }
}