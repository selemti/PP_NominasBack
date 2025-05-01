using System;
using System.ComponentModel.DataAnnotations;

namespace PP_NominasBack.Dtos.Catalogos.CompensacionesDeducciones
{
    public class EmpleadoCompensacionDto
    {
        [Required]
        [Display(Name = "Id")]
        public string Id { get; set; }

        [Required]
        [Display(Name = "EmpleadoId")]
        public string EmpleadoId { get; set; }

        [Required]
        [Display(Name = "CompensacionId")]
        public string CompensacionId { get; set; }

        [Display(Name = "Valor")]
        public decimal? Valor { get; set; }

        [Display(Name = "TipoAsignacion")]
        public int? TipoAsignacion { get; set; }

        [Required]
        [Display(Name = "Formula")]
        public string Formula { get; set; }

        [Display(Name = "Periodicidad")]
        public int? Periodicidad { get; set; }

        [Display(Name = "FechaInicio")]
        public DateTime? FechaInicio { get; set; }

        [Display(Name = "FechaFin")]
        public DateTime? FechaFin { get; set; }

        [Display(Name = "Vigente")]
        public bool? Vigente { get; set; }

        [Required]
        [Display(Name = "Auditable")]
        public string Auditable { get; set; }

    }
}