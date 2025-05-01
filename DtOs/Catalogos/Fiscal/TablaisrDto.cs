using System;
using System.ComponentModel.DataAnnotations;

namespace PP_NominasBack.Dtos.Catalogos.Fiscal
{
    public class TablaIsrDto
    {
        [Required]
        [Display(Name = "Id")]
        public string Id { get; set; }

        [Display(Name = "LimiteInferior")]
        public decimal? LimiteInferior { get; set; }

        [Display(Name = "LimiteSuperior")]
        public decimal? LimiteSuperior { get; set; }

        [Display(Name = "CuotaFija")]
        public decimal? CuotaFija { get; set; }

        [Display(Name = "PorcentajeExcedente")]
        public decimal? PorcentajeExcedente { get; set; }

        [Display(Name = "Periodo")]
        public int? Periodo { get; set; }

        [Display(Name = "EjercicioFiscal")]
        public int? EjercicioFiscal { get; set; }

        [Required]
        [Display(Name = "Auditable")]
        public string Auditable { get; set; }

    }
}