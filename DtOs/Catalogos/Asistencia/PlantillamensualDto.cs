using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PP_NominasBack.Models.Catalogos.Shared;

namespace PP_NominasBack.Dtos.Catalogos.Asistencia
{
    public class PlantillaMensualDto
    {
        [Display(Name = "ID de la plantilla mensual")]
        [Required]
        public List<string> Id { get; set; }

        [Display(Name = "Mes aplicable (1-12)")]
        [Required]
        public List<int?> Mes { get; set; }

        [Display(Name = "Año aplicable")]
        [Required]
        public List<int?> AO { get; set; }

        [Display(Name = "Horario usado en el mes")]
        [Required]
        public List<string> HorarioPlantillaId { get; set; }

        [Display(Name = "Hereda campos de auditoría")]
        [Required]
        public List<Auditable?> Auditable { get; set; }

    }
}
