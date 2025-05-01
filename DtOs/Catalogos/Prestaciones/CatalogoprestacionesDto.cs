using System;
using System.ComponentModel.DataAnnotations;
using PP_NominasBack.DTOs.Catalogos.Shared;

namespace PP_NominasBack.DTOs.Catalogos.Prestaciones
{
    public class CatalogoprestacionesDto
    {
        /// Nombre de la prestación
        public string NombrePrestacion { get; set; }

        /// Descripción breve
        public string DescripcionPrestacion { get; set; }

        /// Empresa relacionada
        public string? AplicaEmpresaId { get; set; }

        /// División relacionada
        public string? AplicaDivisionId { get; set; }

        /// Hereda campos de auditoría
        public string? Auditable { get; set; }

    }
}