using System;
using System.ComponentModel.DataAnnotations;
using PP_NominasBack.DTOs.Catalogos.Shared;

namespace PP_NominasBack.DTOs.Catalogos.Configuración
{
    public class ModulosDto
    {
        /// Nombre del módulo
        public string Nombre { get; set; }

        /// Descripción del módulo
        public string Descripcion { get; set; }

        /// Indica si está habilitado
        [Required]
        public bool Activo { get; set; }

        /// Hereda campos de auditoría
        public string? Auditable { get; set; }

    }
}