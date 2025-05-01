using System;
using System.ComponentModel.DataAnnotations;
using PP_NominasBack.DTOs.Catalogos.Shared;

namespace PP_NominasBack.DTOs.Catalogos.Shared
{
    public class CatalogoenumsDto
    {
        /// Código del enum (grupo)
        public string EnumCode { get; set; }

        /// Clave interna del valor
        public string EnumKey { get; set; }

        /// Valor textual del enum
        public string Valor { get; set; }

        /// Descripción extendida del valor
        public string Descripcion { get; set; }

        /// Si el enum está activo o deprecated
        [Required]
        public bool Activo { get; set; }

        /// Hereda campos de auditoría
        public string? Auditable { get; set; }

    }
}