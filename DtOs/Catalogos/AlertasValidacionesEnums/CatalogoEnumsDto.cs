using System;
using System.ComponentModel.DataAnnotations;

namespace PP_NominasBack.Dtos.Catalogos.AlertasValidacionesEnums
{
    public class CatalogoEnumsDto
    {
        [Required]
        [Display(Name = "Id")]
        public string Id { get; set; }

        [Required]
        [Display(Name = "EnumCode")]
        public string EnumCode { get; set; }

        [Display(Name = "EnumKey")]
        public int? EnumKey { get; set; }

        [Required]
        [Display(Name = "Valor")]
        public string Valor { get; set; }

        [Required]
        [Display(Name = "Descripcion")]
        public string Descripcion { get; set; }

        [Display(Name = "Activo")]
        public bool? Activo { get; set; }

        [Required]
        [Display(Name = "Auditable")]
        public string Auditable { get; set; }

    }
}