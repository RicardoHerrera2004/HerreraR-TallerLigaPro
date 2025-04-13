using HerreraR_TallerLigaPro.Interfaces;
using HerreraR_TallerLigaPro.Models;
using HerreraR_TallerLigaPro.Repositorios;
using Microsoft.AspNetCore.Mvc;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace HerreraR_TallerLigaPro.Controllers
{
    public class EquipoController : Controller
    {
        private static EquipoRepo repository = new EquipoRepo();
        public IActionResult ListaEquipos()
        {
            var equipos = repository.DevuelveListadoEquipos();
            return View(equipos);
        }

        [HttpGet]
        public IActionResult EditarEquipo(int Id)
        {
            var equipo = repository.DevuelveInfoEquipo(Id);
            if (equipo == null)
            {
                return NotFound();
            }
            return View(equipo);
        }

        [HttpPost]
        public IActionResult EditarEquipo(Equipo equipo)
        {
            bool actualizado = repository.ActualizarEquipo(equipo);

            if (actualizado)
                return RedirectToAction("ListaEquipos");

            return NotFound();
        }

        //Función generada por IA
        [HttpPost]
        public IActionResult ActualizarEquipo(Equipo equipo)
        {
            bool actualizado = repository.ActualizarEquipo(equipo);

            if (actualizado)
                return RedirectToAction("ListaEquipos");

            return NotFound(); 
        }
    }
}
