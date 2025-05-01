using System;
using System.ComponentModel.DataAnnotations;
using PP_NominasBack.DTOs.Catalogos.Shared;

namespace PP_NominasBack.DTOs.Catalogos.Nómina
{
    public class CfdinominaDto
    {
        /// Recibo relacionado
        public string? ReciboNominaId { get; set; }

        /// UUID del comprobante SAT
        public string? Uuid { get; set; }

        /// Sello digital del CFDI
        public string SelloDigital { get; set; }

        /// Fecha de timbrado SAT
        [Required]
        public DateTime FechaTimbre { get; set; }

        /// Hereda campos de auditoría
        public string? Auditable { get; set; }

    }
}