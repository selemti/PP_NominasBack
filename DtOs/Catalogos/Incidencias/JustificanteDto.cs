using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PP_NominasBack.Models.Catalogos.Shared;

namespace PP_NominasBack.Dtos.Catalogos.Incidencias
{
    public class JustificanteDto
    {
        [Display(Name = "ID del justificante de incidencia")]
        [Required]
        public List<string> Id { get; set; }

        [Display(Name = "Tipo de documento (certificado médico, etc.)")]
        [Required]
        public List<int?> TipoJustificante { get; set; }

        [Display(Name = "URL del archivo digital")]
        [Required]
        public List<string> UrlDocumento { get; set; }

        [Display(Name = "Fecha de emisión del documento")]
        [Required]
        public List<DateTime?> FechaEmision { get; set; }

        [Display(Name = "Hereda campos de auditoría")]
        [Required]
        public List<Auditable?> Auditable { get; set; }

    }
}
