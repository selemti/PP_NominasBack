using System;
using System.ComponentModel.DataAnnotations;
using PP_NominasBack.DTOs.Catalogos.Shared;

namespace PP_NominasBack.DTOs.Catalogos.Nómina
{
    public class DetallededuccionesDto
    {
        /// Recibo de nómina asociado
        public string? ReciboNominaId { get; set; }

        /// Concepto de deducción aplicada
        public string? TipoDeduccionId { get; set; }

        /// Monto de la deducción
        public string Monto { get; set; }

        /// Hereda campos de auditoría
        public string? Auditable { get; set; }

    }
}