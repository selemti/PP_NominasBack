using System;
using System.ComponentModel.DataAnnotations;

namespace PP_NominasBack.Dtos.Catalogos.Asistencia
{
    public class HorarioPlantillaDto
    {
        [Required]
        [Display(Name = "Id")]
        public string Id { get; set; }

        [Required]
        [Display(Name = "NombrePlantilla")]
        public string NombrePlantilla { get; set; }

        [Required]
        [Display(Name = "DescripcionPlantilla")]
        public string DescripcionPlantilla { get; set; }

        [Required]
        [Display(Name = "TurnoId")]
        public string TurnoId { get; set; }

        [Required]
        [Display(Name = "Auditable")]
        public string Auditable { get; set; }

    }
}