using HerreraR_TallerLigaPro.Interfaces;
using HerreraR_TallerLigaPro.Models;

namespace HerreraR_TallerLigaPro.Repositorios
{
    public class EquipoRepo : IEquiposRepo
    {
        public bool ActualizarEquipo()
        {
            throw new NotImplementedException();
        }

        public bool CrearEquipo()
        {
            throw new NotImplementedException();
        }

        public Equipo DevuelveInfoEquipo(int Id)
        {
            var equipos = DevuelveListadoEquipos();
            var equipo = equipos.Where(item => item.Id == Id).First();
            return equipo;
        }

        public List<Equipo> DevuelveListadoEquipos()
        {
            List<Equipo> equipos = new List<Equipo>();
            Equipo LDU = new Equipo
            {
                Id = 1,
                Nombre = "LDU",
                PartidosJugados = 10,
                PartidosGanados = 10,
                PartidosEmpatados = 0,
                PartidosPerdidos = 0,
                ImagenEquipo = "LDU.jpeg"
            };
            equipos.Add(LDU);

            Equipo Barcelona = new Equipo
            {
                Id = 2,
                Nombre = "Barcelona",
                PartidosJugados = 10,
                PartidosGanados = 6,
                PartidosEmpatados = 3,
                PartidosPerdidos = 1,
                ImagenEquipo = "Barcelona.jpeg"
            };
            equipos.Add(Barcelona);

            Equipo Emelec = new Equipo
            {
                Id = 3,
                Nombre = "Emelec",
                PartidosJugados = 10,
                PartidosGanados = 3,
                PartidosEmpatados = 6,
                PartidosPerdidos = 1,
                ImagenEquipo = "Emelec.jpg"
            };
            equipos.Add(Emelec);

            Equipo Nacional = new Equipo
            {
                Id = 4,
                Nombre = "Nacional",
                PartidosJugados = 10,
                PartidosGanados = 6,
                PartidosEmpatados = 1,
                PartidosPerdidos = 3,
                ImagenEquipo = "Nacional.jpg"
            };
            equipos.Add(Nacional);

            Equipo IDV = new Equipo
            {
                Id = 3,
                Nombre = "IDV",
                PartidosJugados = 10,
                PartidosGanados = 3,
                PartidosEmpatados = 5,
                PartidosPerdidos = 2,
                ImagenEquipo = "IDV.jpeg"
            };
            equipos.Add(IDV);

            return equipos;
        }

        public bool EliminarEquipo()
        {
            throw new NotImplementedException();
        }
    }
}
