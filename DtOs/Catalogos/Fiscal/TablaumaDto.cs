using System;
using System.ComponentModel.DataAnnotations;

namespace PP_NominasBack.Dtos.Catalogos.Fiscal
{
    public class TablaUmaDto
    {
        [Required]
        [Display(Name = "Id")]
        public string Id { get; set; }

        [Display(Name = "ValorUma")]
        public decimal? ValorUma { get; set; }

        [Display(Name = "FechaInicioVigencia")]
        public DateTime? FechaInicioVigencia { get; set; }

        [Display(Name = "FechaFinVigencia")]
        public DateTime? FechaFinVigencia { get; set; }

        [Display(Name = "EjercicioFiscal")]
        public int? EjercicioFiscal { get; set; }

        [Required]
        [Display(Name = "Auditable")]
        public string Auditable { get; set; }

    }
}