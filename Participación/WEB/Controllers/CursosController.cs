using Microsoft.AspNetCore.Mvc;

namespace WEB.Controllers
{
    public class CursosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Microeconomia()
        {
            return View();
        }

        public IActionResult Ing_de_software()
        {
            return View();
        }

        public IActionResult Programacion_1()
        {
            return View();
        }

        public IActionResult Sistemas_de_Info()
        {
            return View();
        }

        public IActionResult Metodos_Trabajo()
        {
            return View();
        }
    }
}