using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace HerreraR_TallerLigaPro.Models
{
    public class Equipo
    {
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
    }
}
