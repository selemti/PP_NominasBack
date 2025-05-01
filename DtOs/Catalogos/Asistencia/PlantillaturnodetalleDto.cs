using System;
using System.ComponentModel.DataAnnotations;

namespace PP_NominasBack.Dtos.Catalogos.Asistencia
{
    public class PlantillaTurnoDetalleDto
    {
        [Required]
        [Display(Name = "Id")]
        public string Id { get; set; }

        [Required]
        [Display(Name = "PlantillaId")]
        public string PlantillaId { get; set; }

        [Display(Name = "Fecha")]
        public DateTime? Fecha { get; set; }

        [Required]
        [Display(Name = "TurnoId")]
        public string TurnoId { get; set; }

        [Required]
        [Display(Name = "PlazaId")]
        public string PlazaId { get; set; }

        [Required]
        [Display(Name = "Auditable")]
        public string Auditable { get; set; }

    }
}