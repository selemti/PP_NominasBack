// Dtos/Catalogos/Shared/CatalogoEnumsDto.cs
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PP_NominasBack.Dtos.Catalogos.Shared
{
    /// <summary>
    /// DTO genérico para exponer colecciones de enums.
    /// </summary>
    public class CatalogoEnumsDto
    {
        [Display(Name = "Identificador único del elemento")]
        public int Key { get; set; }

        [Display(Name = "Valor textual del enum")]
        public string Value { get; set; } = null!;
    }

    /// <summary>
    /// Contenedor para múltiples catálogos de enums.
    /// </summary>
    public class CatalogoEnumsCollectionDto
    {
        [Display(Name = "Nombre del catálogo (tipo de enum)")]
        public string CatalogName { get; set; } = null!;

        [Display(Name = "Items del catálogo")]
        public List<CatalogoEnumsDto> Items { get; set; } = new();
    }
}
