using System;
using System.ComponentModel.DataAnnotations;

namespace PP_NominasBack.Dtos.Catalogos.ContratosPrestaciones
{
    public class TabuladorSalarialDto
    {
        [Required]
        [Display(Name = "Id")]
        public string Id { get; set; }

        [Required]
        [Display(Name = "PuestoId")]
        public string PuestoId { get; set; }

        [Display(Name = "SalarioMinimo")]
        public decimal? SalarioMinimo { get; set; }

        [Display(Name = "SalarioMaximo")]
        public decimal? SalarioMaximo { get; set; }

        [Required]
        [Display(Name = "Auditable")]
        public string Auditable { get; set; }

    }
}