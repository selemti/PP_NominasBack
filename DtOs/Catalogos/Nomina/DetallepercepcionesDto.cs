using System;
using System.ComponentModel.DataAnnotations;
using PP_NominasBack.DTOs.Catalogos.Shared;

namespace PP_NominasBack.DTOs.Catalogos.Nómina
{
    public class DetallepercepcionesDto
    {
        /// Recibo de nómina asociado
        public string? ReciboNominaId { get; set; }

        /// Concepto de percepción aplicada
        public string? TipoCompensacionId { get; set; }

        /// Monto de la percepción
        public string Monto { get; set; }

        /// (0 = Gravado, 1 = Exento, 2 = Excedente)
        [Required]
        public TipoFiscalizacionEnum TipoFiscalizacion { get; set; }

        /// Hereda campos de auditoría
        public string? Auditable { get; set; }

    }
}