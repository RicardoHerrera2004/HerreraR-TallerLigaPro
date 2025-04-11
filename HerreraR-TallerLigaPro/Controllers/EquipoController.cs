using HerreraR_TallerLigaPro.Models;
using HerreraR_TallerLigaPro.Repositorios;
using Microsoft.AspNetCore.Mvc;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace HerreraR_TallerLigaPro.Controllers
{
    public class EquipoController : Controller
    {
        public IActionResult ListaEquipos()
        {
            EquipoRepo repository = new EquipoRepo();
            var equipos = repository.DevuelveListadoEquipos();            
            
            return View(equipos);
        }

        public IActionResult EditarEquipo(int Id)
        {
            EquipoRepo repository = new EquipoRepo();
            var equipo = repository.DevuelveInfoEquipo(Id);
            return View(equipo);
        }
    }
}
