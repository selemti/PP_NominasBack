using System;
using System.ComponentModel.DataAnnotations;

namespace PP_NominasBack.Dtos.Catalogos.FondosAhorro
{
    public class FondoAhorroDto
    {
        [Required]
        [Display(Name = "Id")]
        public string Id { get; set; }

        [Required]
        [Display(Name = "EmpleadoId")]
        public string EmpleadoId { get; set; }

        [Display(Name = "SaldoActual")]
        public decimal? SaldoActual { get; set; }

        [Display(Name = "PorcentajeAportacion")]
        public decimal? PorcentajeAportacion { get; set; }

        [Display(Name = "Vigente")]
        public bool? Vigente { get; set; }

        [Required]
        [Display(Name = "Auditable")]
        public string Auditable { get; set; }

    }
}