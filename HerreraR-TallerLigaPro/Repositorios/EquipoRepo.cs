using HerreraR_TallerLigaPro.Interfaces;
using HerreraR_TallerLigaPro.Models;

namespace HerreraR_TallerLigaPro.Repositorios
{
    public class EquipoRepo : IEquiposRepo
    {
        private static List<Equipo> ListaEquipo;
            static EquipoRepo()
        {
            if (ListaEquipo == null)
            {
                ListaEquipo = new List<Equipo>()
                {
                    new Equipo()
                    {
                        Id = 1,
                        Nombre = "LDU",
                        PartidosJugados = 10,
                        PartidosGanados = 10,
                        PartidosEmpatados = 0,
                        PartidosPerdidos = 0,
                        ImagenEquipo = "LDU.jpeg",
                        DescripcionEquipo = "EL mejor equipo de la LigaPro, rey de copas y vigente campeón del a competición"
                    },
                    new Equipo()
                    {
                        Id = 2,
                        Nombre = "Barcelona",
                        PartidosJugados = 10,
                        PartidosGanados = 6,
                        PartidosEmpatados = 3,
                        PartidosPerdidos = 1,
                        ImagenEquipo = "Barcelona.jpeg",
                        DescripcionEquipo = "El equipo con más fanaticada de toda la competición, conocido como el ídolo del Ecuador"
                    },
                    new Equipo()
                    {
                        Id = 3,
                        Nombre = "Emelec",
                        PartidosJugados = 10,
                        PartidosGanados = 3,
                        PartidosEmpatados = 6,
                        PartidosPerdidos = 1,
                        ImagenEquipo = "Emelec.jpg",
                        DescripcionEquipo = "El equipo millonario del Ecuador"
                    },
                    new Equipo()
                    {
                        Id = 4,
                        Nombre = "Nacional",
                        PartidosJugados = 10,
                        PartidosGanados = 6,
                        PartidosEmpatados = 1,
                        PartidosPerdidos = 3,
                        ImagenEquipo = "Nacional.jpg",
                        DescripcionEquipo = "El equipo criollo del Ecuador donde se ha caracterizado por tener un plantel de deportistas de nacionalidad ecuatoriana"
                    },
                    new Equipo()
                    {
                        Id = 5,
                        Nombre = "IDV",
                        PartidosJugados = 10,
                        PartidosGanados = 3,
                        PartidosEmpatados = 5,
                        PartidosPerdidos = 2,
                        ImagenEquipo = "IDV.jpeg",
                        DescripcionEquipo = "El equipo Matagigantes y con una gran cantera para el fútbol ecuatoriano"
                    }
                };
            }
        }

        //Codigo generado por IA para la función ascendiente de los puntos de los equipos
        public List<Equipo> DevuelveListadoEquipos()
        {
            return ListaEquipo
           .OrderByDescending(e => e.Puntos) 
           .ToList();
        }

        public Equipo DevuelveInfoEquipo(int Id)
        {
            var equipos = DevuelveListadoEquipos();
            var equipo = equipos.Where(item => item.Id == Id).First();
            return equipo;
        }

        //Función generada por IA
        public bool ActualizarEquipo(Equipo equipo)
        {
            var equipoExistente = ListaEquipo.FirstOrDefault(e => e.Id == equipo.Id);
            if (equipoExistente != null)
            {
                equipoExistente.PartidosJugados = equipo.PartidosJugados;
                equipoExistente.PartidosGanados = equipo.PartidosGanados;
                equipoExistente.PartidosPerdidos = equipo.PartidosPerdidos;
                equipoExistente.PartidosEmpatados = equipo.PartidosEmpatados;
                equipoExistente.Id = equipo.Id;
                equipoExistente.DescripcionEquipo = equipo.DescripcionEquipo;
                equipoExistente.ImagenEquipo = equipo.ImagenEquipo;
                return true;
            }
            return false;
        }

        public Equipo ObtenerEquipoPorId(int id)
        {
            return ListaEquipo.FirstOrDefault(e => e.Id == id);
        }

        public bool CrearEquipo()
        {
            throw new NotImplementedException();
        }

        public bool EliminarEquipo()
        {
            throw new NotImplementedException();
        }
    }
}
