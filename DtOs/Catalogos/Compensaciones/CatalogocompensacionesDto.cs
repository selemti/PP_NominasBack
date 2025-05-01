using System;
using System.ComponentModel.DataAnnotations;
using PP_NominasBack.DTOs.Catalogos.Shared;

namespace PP_NominasBack.DTOs.Catalogos.Compensaciones
{
    public class CatalogocompensacionesDto
    {
        /// Tipo (0 = Bono, 1 = Comisión, 2 = Premio)
        [Required]
        public TipoCompensacionEnum TipoCompensacion { get; set; }

        /// Nombre del concepto
        public string NombreCompensacion { get; set; }

        /// Descripción breve
        public string DescripcionCompensacion { get; set; }

        /// Empresa relacionada (opcional)
        public string? AplicaEmpresaId { get; set; }

        /// División relacionada (opcional)
        public string? AplicaDivisionId { get; set; }

        /// Hereda campos de auditoría
        public string? Auditable { get; set; }

    }
}