using HerreraR_TallerLigaPro.Models;

namespace HerreraR_TallerLigaPro.Interfaces
{
    public interface IEquiposRepo
    {
        List<Equipo> DevuelveListadoEquipos();
        Equipo DevuelveInfoEquipo(int Id);
       
        bool ActualizarEquipo(Equipo equipo);
        Equipo ObtenerEquipoPorId(int id);
        
        //Estas dos funciones no están siendo utilizadas actualmente en el programa
        /*bool CrearEquipo();
        bool EliminarEquipo();*/
    }
}
