using System;
using System.ComponentModel.DataAnnotations;

namespace PP_NominasBack.Dtos.Catalogos.VacacionesPermisos
{
    public class PeriodoVacacionalDto
    {
        [Required]
        [Display(Name = "Id")]
        public string Id { get; set; }

        [Display(Name = "Anio")]
        public int? Anio { get; set; }

        [Display(Name = "DiasAsignados")]
        public int? DiasAsignados { get; set; }

        [Required]
        [Display(Name = "Auditable")]
        public string Auditable { get; set; }

    }
}