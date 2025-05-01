using System;
using System.ComponentModel.DataAnnotations;

namespace PP_NominasBack.Dtos.Catalogos.Fiscal
{
    public class TablaImssDto
    {
        [Required]
        [Display(Name = "Id")]
        public string Id { get; set; }

        [Required]
        [Display(Name = "Concepto")]
        public string Concepto { get; set; }

        [Display(Name = "PorcentajePatronal")]
        public decimal? PorcentajePatronal { get; set; }

        [Display(Name = "PorcentajeObrero")]
        public decimal? PorcentajeObrero { get; set; }

        [Display(Name = "SalarioMinimoAplica")]
        public bool? SalarioMinimoAplica { get; set; }

        [Display(Name = "EjercicioFiscal")]
        public int? EjercicioFiscal { get; set; }

        [Required]
        [Display(Name = "Auditable")]
        public string Auditable { get; set; }

    }
}