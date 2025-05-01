using System;
using System.ComponentModel.DataAnnotations;

namespace PP_NominasBack.Dtos.Catalogos.AlertasValidacionesEnums
{
    public class DestinatarioAlertaDto
    {
        [Required]
        [Display(Name = "Id")]
        public string Id { get; set; }

        [Required]
        [Display(Name = "AlertaId")]
        public string AlertaId { get; set; }

        [Display(Name = "TipoDestinatario")]
        public int? TipoDestinatario { get; set; }

        [Required]
        [Display(Name = "ValorDestino")]
        public string ValorDestino { get; set; }

        [Required]
        [Display(Name = "Auditable")]
        public string Auditable { get; set; }

    }
}