using System;
using System.ComponentModel.DataAnnotations;

namespace PP_NominasBack.Dtos.Catalogos.Fiscal
{
    public class TablaInfonavitDto
    {
        [Required]
        [Display(Name = "Id")]
        public string Id { get; set; }

        [Display(Name = "TipoDescuento")]
        public int? TipoDescuento { get; set; }

        [Display(Name = "ValorDescuento")]
        public decimal? ValorDescuento { get; set; }

        [Required]
        [Display(Name = "Descripcion")]
        public string Descripcion { get; set; }

        [Display(Name = "EjercicioFiscal")]
        public int? EjercicioFiscal { get; set; }

        [Required]
        [Display(Name = "Auditable")]
        public string Auditable { get; set; }

    }
}