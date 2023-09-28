using Microsoft.AspNetCore.Mvc;
using Unidad1Actividad1.Models;

namespace Unidad1Actividad1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            MiPerfilViewModel perfil = new();
            perfil.Nombre = "Sergio Emanuel Ramos Rodriguez";
            perfil.Materia = "Programacion Web";
            perfil.Semestres = 7;
            perfil.Periodo = "Agosto-Diciembre 2023";
            return View(perfil);
        }
        public IActionResult MiPerfil()
        {
           
            return View();
        }
       
    }
}

    
