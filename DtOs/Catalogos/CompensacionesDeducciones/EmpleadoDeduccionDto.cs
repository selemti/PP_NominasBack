using System;
using System.ComponentModel.DataAnnotations;

namespace PP_NominasBack.Dtos.Catalogos.CompensacionesDeducciones
{
    public class EmpleadoDeduccionDto
    {
        [Required]
        [Display(Name = "Id")]
        public string Id { get; set; }

        [Required]
        [Display(Name = "EmpleadoId")]
        public string EmpleadoId { get; set; }

        [Required]
        [Display(Name = "DeduccionId")]
        public string DeduccionId { get; set; }

        [Display(Name = "Valor")]
        public decimal? Valor { get; set; }

        [Display(Name = "Periodicidad")]
        public int? Periodicidad { get; set; }

        [Display(Name = "FechaInicio")]
        public DateTime? FechaInicio { get; set; }

        [Display(Name = "FechaFin")]
        public DateTime? FechaFin { get; set; }

        [Required]
        [Display(Name = "Auditable")]
        public string Auditable { get; set; }

    }
}