using System;
using System.ComponentModel.DataAnnotations;
using PP_NominasBack.DTOs.Catalogos.Shared;

namespace PP_NominasBack.DTOs.Catalogos.Nómina
{
    public class FiniquitoliquidacionDto
    {
        /// Empleado liquidado
        public string? EmpleadoId { get; set; }

        /// Fecha del finiquito/liquidación
        [Required]
        public DateTime FechaFiniquito { get; set; }

        /// Listado de percepciones/deducciones aplicadas
        public required string Conceptos { get; set; }

        /// ISR especial calculado para finiquito
        public required string IsrCalculado { get; set; }

        /// Neto a pagar por finiquito/liquidación
        public required string TotalFiniquito { get; set; }

        /// Hereda campos de auditoría
        public string? Auditable { get; set; }

    }
}