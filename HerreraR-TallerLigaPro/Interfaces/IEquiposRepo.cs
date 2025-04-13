using HerreraR_TallerLigaPro.Models;

namespace HerreraR_TallerLigaPro.Interfaces
{
    public interface IEquiposRepo
    {
        List<Equipo> DevuelveListadoEquipos();
        Equipo DevuelveInfoEquipo(int Id);
        bool CrearEquipo();
        bool ActualizarEquipo(Equipo equipo);
        bool EliminarEquipo();
        Equipo ObtenerEquipoPorId(int id);
    }
}
