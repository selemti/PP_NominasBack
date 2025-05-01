using System;
using System.ComponentModel.DataAnnotations;

namespace PP_NominasBack.Dtos.Catalogos.PrenominaNomina
{
    public class DetalleDeduccionesDto
    {
        [Required]
        [Display(Name = "Id")]
        public string Id { get; set; }

        [Required]
        [Display(Name = "ReciboNominaId")]
        public string ReciboNominaId { get; set; }

        [Required]
        [Display(Name = "TipoDeduccionId")]
        public string TipoDeduccionId { get; set; }

        [Display(Name = "Monto")]
        public decimal? Monto { get; set; }

        [Required]
        [Display(Name = "Auditable")]
        public string Auditable { get; set; }

    }
}