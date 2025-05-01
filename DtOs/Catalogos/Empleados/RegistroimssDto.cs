using System;
using System.ComponentModel.DataAnnotations;
using PP_NominasBack.DTOs.Catalogos.Shared;

namespace PP_NominasBack.DTOs.Catalogos.Empleados
{
    public class RegistroimssDto
    {
        /// Empleado relacionado
        public string? EmpleadoId { get; set; }

        /// Fecha de alta ante IMSS
        [Required]
        public DateTime FechaAlta { get; set; }

        /// Fecha de baja ante IMSS
        [Required]
        public DateTime FechaBaja { get; set; }

        /// Número de Seguridad Social
        public string Nss { get; set; }

        /// Hereda campos de auditoría
        public string? Auditable { get; set; }

    }
}