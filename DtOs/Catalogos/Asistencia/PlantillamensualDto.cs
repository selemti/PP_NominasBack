using System;
using System.ComponentModel.DataAnnotations;

namespace PP_NominasBack.Dtos.Catalogos.Asistencia
{
    public class PlantillaMensualDto
    {
        [Required]
        [Display(Name = "Id")]
        public string Id { get; set; }

        [Display(Name = "Mes")]
        public int? Mes { get; set; }

        [Display(Name = "Ano")]
        public int? Ano { get; set; }

        [Required]
        [Display(Name = "HorarioPlantillaId")]
        public string HorarioPlantillaId { get; set; }

        [Required]
        [Display(Name = "Auditable")]
        public string Auditable { get; set; }

    }
}