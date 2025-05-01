using System;
using System.ComponentModel.DataAnnotations;
using PP_NominasBack.DTOs.Catalogos.Shared;

namespace PP_NominasBack.DTOs.Catalogos.Fondos
{
    public class MovimientofondoahorroDto
    {
        /// Fondo relacionado
        public string? FondoAhorroId { get; set; }

        /// (0 = Aportación, 1 = Retiro, 2 = Interés generado)
        [Required]
        public TipoMovimientoEnum TipoMovimiento { get; set; }

        /// Monto del movimiento
        public string Monto { get; set; }

        /// Fecha de operación
        [Required]
        public DateTime FechaMovimiento { get; set; }

        /// Descripción breve del movimiento
        public string Descripcion { get; set; }

        /// Hereda campos de auditoría
        public string? Auditable { get; set; }

    }
}