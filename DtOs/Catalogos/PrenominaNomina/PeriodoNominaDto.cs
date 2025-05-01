using System;
using System.ComponentModel.DataAnnotations;

namespace PP_NominasBack.Dtos.Catalogos.PrenominaNomina
{
    public class PeriodoNominaDto
    {
        [Required]
        [Display(Name = "Id")]
        public string Id { get; set; }

        [Display(Name = "FechaInicio")]
        public DateTime? FechaInicio { get; set; }

        [Display(Name = "FechaFin")]
        public DateTime? FechaFin { get; set; }

        [Required]
        [Display(Name = "TipoPeriodoId")]
        public string TipoPeriodoId { get; set; }

        [Required]
        [Display(Name = "Auditable")]
        public string Auditable { get; set; }

        [Display(Name = "TipoNomina")]
        public int? TipoNomina { get; set; }

    }
}