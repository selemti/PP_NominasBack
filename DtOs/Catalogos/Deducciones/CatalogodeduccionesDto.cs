using System;
using System.ComponentModel.DataAnnotations;
using PP_NominasBack.DTOs.Catalogos.Shared;

namespace PP_NominasBack.DTOs.Catalogos.Deducciones
{
    public class CatalogodeduccionesDto
    {
        /// (0 = Fiscal, 1 = Crédito, 2 = Préstamo, 3 = Especial, 4 = FONACOT, 5 = Pensión Alimenticia, 6 = Otro, 7 = Multa Interna, 8 = Retención Judicial)
        [Required]
        public TipoDeduccionEnum TipoDeduccion { get; set; }

        /// Nombre de la deducción
        public string NombreDeduccion { get; set; }

        /// Descripción de la deducción
        public string DescripcionDeduccion { get; set; }

        /// Empresa aplicable
        public string? AplicaEmpresaId { get; set; }

        /// Hereda campos de auditoría
        public string? Auditable { get; set; }

    }
}