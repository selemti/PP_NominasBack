using System;
using System.ComponentModel.DataAnnotations;

namespace PP_NominasBack.Dtos.Catalogos.Fiscal
{
    public class CuotaObreroPatronalDto
    {
        [Required]
        [Display(Name = "Id")]
        public string Id { get; set; }

        [Required]
        [Display(Name = "Concepto")]
        public string Concepto { get; set; }

        [Display(Name = "PorcentajePatron")]
        public decimal? PorcentajePatron { get; set; }

        [Display(Name = "PorcentajeEmpleado")]
        public decimal? PorcentajeEmpleado { get; set; }

        [Display(Name = "VigenciaInicio")]
        public DateTime? VigenciaInicio { get; set; }

        [Display(Name = "VigenciaFin")]
        public DateTime? VigenciaFin { get; set; }

        [Required]
        [Display(Name = "Auditable")]
        public string Auditable { get; set; }

    }
}