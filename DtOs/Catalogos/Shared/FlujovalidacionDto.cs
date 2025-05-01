using System;
using System.ComponentModel.DataAnnotations;
using PP_NominasBack.DTOs.Catalogos.Shared;

namespace PP_NominasBack.DTOs.Catalogos.Shared
{
    public class FlujovalidacionDto
    {
        /// Nombre descriptivo del flujo
        public string NombreFlujo { get; set; }

        /// Nombre del proceso al que aplica
        public string ProcesoRelacionado { get; set; }

        /// Descripción breve del flujo
        public string DescripcionFlujo { get; set; }

        /// Si el flujo está activo o no
        [Required]
        public bool Activo { get; set; }

        /// Hereda campos de auditoría
        public string? Auditable { get; set; }

    }
}