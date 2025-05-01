using System;
using System.ComponentModel.DataAnnotations;

namespace PP_NominasBack.Dtos.Catalogos.Incidencias
{
    public class JustificanteDto
    {
        [Required]
        [Display(Name = "Id")]
        public string Id { get; set; }

        [Display(Name = "TipoJustificante")]
        public int? TipoJustificante { get; set; }

        [Required]
        [Display(Name = "UrlDocumento")]
        public string UrlDocumento { get; set; }

        [Display(Name = "FechaEmision")]
        public DateTime? FechaEmision { get; set; }

        [Required]
        [Display(Name = "Auditable")]
        public string Auditable { get; set; }

    }
}