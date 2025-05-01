using System;
using System.ComponentModel.DataAnnotations;

namespace PP_NominasBack.Dtos.Catalogos.AlertasValidacionesEnums
{
    public class FlujoValidacionDto
    {
        [Required]
        [Display(Name = "Id")]
        public string Id { get; set; }

        [Required]
        [Display(Name = "NombreFlujo")]
        public string NombreFlujo { get; set; }

        [Required]
        [Display(Name = "ProcesoRelacionado")]
        public string ProcesoRelacionado { get; set; }

        [Required]
        [Display(Name = "DescripcionFlujo")]
        public string DescripcionFlujo { get; set; }

        [Display(Name = "Activo")]
        public bool? Activo { get; set; }

        [Required]
        [Display(Name = "Auditable")]
        public string Auditable { get; set; }

    }
}