using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace HerreraR_TallerLigaPro.Models
{
    public class Equipo
    {
        [DisplayName("Imagen del equipo ")]
        public string ImagenEquipo { get; set; }
        [DisplayName("Descripción del equipo ")]
        public string DescripcionEquipo { get; set; }
        [Key]
        public int Id { get; set; }
        [MaxLength(100)]
        [DisplayName("Nombre del equipo ")]
        [Required]
        public string Nombre { get; set; }
        [Range(0, 20)]
        public int PartidosJugados { get; set; }
        [Range(0, 20)]
        public int PartidosGanados { get; set; }
        [Range(0, 20)]
        public int PartidosEmpatados { get; set; }
        [Range(0, 20)]
        public int PartidosPerdidos { get; set; }
        public int Puntos
        {
            get
            {
                int puntos = PartidosEmpatados * 1 + PartidosGanados * 3;
                return puntos;
            }
        }

        //Metodo para validar los partidos ingresados en el formulario
        public bool ValidarPartidos()
        {
            return (PartidosEmpatados + PartidosGanados + PartidosPerdidos) == PartidosJugados;
        }

        public string ObtenerErrorPartidos()
        {
            int TotalPartidos = PartidosGanados + PartidosEmpatados + PartidosPerdidos;
            if (TotalPartidos != PartidosJugados)
            {
                return "La suma de los partidos no coinciden, ingrese correctamente los datos de los partidos";
            }
            return null;
        }
    }
}
