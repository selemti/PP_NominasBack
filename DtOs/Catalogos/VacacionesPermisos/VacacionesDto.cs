using System;
using System.ComponentModel.DataAnnotations;

namespace PP_NominasBack.Dtos.Catalogos.VacacionesPermisos
{
    public class VacacionesDto
    {
        [Required]
        [Display(Name = "Id")]
        public string Id { get; set; }

        [Required]
        [Display(Name = "EmpleadoId")]
        public string EmpleadoId { get; set; }

        [Display(Name = "FechaInicio")]
        public DateTime? FechaInicio { get; set; }

        [Display(Name = "FechaFin")]
        public DateTime? FechaFin { get; set; }

        [Display(Name = "DiasProgramados")]
        public int? DiasProgramados { get; set; }

        [Display(Name = "DiasGozados")]
        public int? DiasGozados { get; set; }

        [Required]
        [Display(Name = "PeriodoVacacionalId")]
        public string PeriodoVacacionalId { get; set; }

        [Required]
        [Display(Name = "Auditable")]
        public string Auditable { get; set; }

    }
}