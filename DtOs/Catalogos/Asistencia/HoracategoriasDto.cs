using System;
using System.ComponentModel.DataAnnotations;
using PP_NominasBack.DTOs.Catalogos.Shared;

namespace PP_NominasBack.DTOs.Catalogos.Asistencia
{
    public class HoracategoriasDto
    {
        /// Código de categoría
        public string Codigo { get; set; }

        /// Nombre legible de categoría
        public string Nombre { get; set; }

        /// Descripción extendida
        public string Descripcion { get; set; }

        /// Hereda campos de auditoría
        public string? Auditable { get; set; }

    }
}