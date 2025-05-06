using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PP_NominasBack.Models.Catalogos.Shared;

namespace PP_NominasBack.Dtos.Catalogos.Nomina
{
    public class CfdiNominaDto
    {
        [Display(Name = "ID del CFDI")]
        [Required]
        public List<string> Id { get; set; }

        [Display(Name = "Recibo relacionado")]
        [Required]
        public List<string> ReciboNominaId { get; set; }

        [Display(Name = "UUID del comprobante SAT")]
        [Required]
        public List<string> Uuid { get; set; }

        [Display(Name = "Sello digital del CFDI")]
        [Required]
        public List<string> SelloDigital { get; set; }

        [Display(Name = "Fecha de timbrado SAT")]
        [Required]
        public List<DateTime?> FechaTimbre { get; set; }

        [Display(Name = "Hereda campos de auditoría")]
        [Required]
        public List<Auditable?> Auditable { get; set; }

    }
}
