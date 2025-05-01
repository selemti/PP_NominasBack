using System;
using System.ComponentModel.DataAnnotations;
using PP_NominasBack.DTOs.Catalogos.Shared;

namespace PP_NominasBack.DTOs.Catalogos.Fondos
{
    public class FondoahorroDto
    {
        /// Empleado participante
        public string? EmpleadoId { get; set; }

        /// Saldo acumulado
        public string SaldoActual { get; set; }

        /// Porcentaje aportado
        public string PorcentajeAportacion { get; set; }

        /// Fondo activo o cerrado
        [Required]
        public bool Vigente { get; set; }

        /// Hereda campos de auditoría
        public string? Auditable { get; set; }

    }
}