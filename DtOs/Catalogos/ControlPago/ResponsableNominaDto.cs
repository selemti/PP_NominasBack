using System;
using System.ComponentModel.DataAnnotations;

namespace PP_NominasBack.Dtos.Catalogos.ControlPago
{
    public class ResponsableNominaDto
    {
        [Required]
        [Display(Name = "Id")]
        public string Id { get; set; }

        [Required]
        [Display(Name = "UsuarioId")]
        public string UsuarioId { get; set; }

        [Display(Name = "TipoResponsabilidad")]
        public int? TipoResponsabilidad { get; set; }

        [Required]
        [Display(Name = "CentroPagoNominaId")]
        public string CentroPagoNominaId { get; set; }

        [Required]
        [Display(Name = "Auditable")]
        public string Auditable { get; set; }

    }
}