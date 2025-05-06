using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PP_NominasBack.Models.Catalogos.Shared;

namespace PP_NominasBack.Dtos.Catalogos.Vacaciones
{
    public class PeriodoVacacionalDto
    {
        [Display(Name = "ID del periodo vacacional anual")]
        [Required]
        public List<string> Id { get; set; }

        [Display(Name = "Año aplicable")]
        [Required]
        public List<int?> Anio { get; set; }

        [Display(Name = "Días asignados anuales")]
        [Required]
        public List<int?> DiasAsignados { get; set; }

        [Display(Name = "Hereda campos de auditoría")]
        [Required]
        public List<Auditable?> Auditable { get; set; }

    }
}
